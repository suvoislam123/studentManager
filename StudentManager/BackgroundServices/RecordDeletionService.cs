using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StudentManager.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManager.BackgroundServices
{
    
    public class RecordDeletionService : BackgroundService
    {
        private readonly ILogger<RecordDeletionService> _logger;
        private readonly ConcurrentQueue<List<Guid>> _deleteQueue = new ConcurrentQueue<List<Guid>>();
        private readonly IServiceProvider _serviceProvider;

        public RecordDeletionService(IServiceProvider serviceProvider, ILogger<RecordDeletionService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public void EnqueueRecordIds(List<Guid> recordIds)
        {
            _deleteQueue.Enqueue(recordIds);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    if (_deleteQueue.TryDequeue(out var recordIds))
                    {
                        await PerformDeletionAsync(recordIds, stoppingToken);
                    }

                    await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken); // Adjust delay as needed
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while deleting records.");
                }
            }
        }

        private async Task PerformDeletionAsync(List<Guid> recordIds, CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<StudentManagerDbContext>();

                foreach (var id in recordIds)
                {
                    var student = await dbContext.Students.FindAsync(id);
                    if (student != null)
                    {
                        dbContext.Students.Remove(student);
                    }
                    else
                    {
                        // Handle error or continue to the next record
                    }
                    Thread.Sleep(1000);
                }

                await dbContext.SaveChangesAsync(cancellationToken);

            }
        }
    }

}
