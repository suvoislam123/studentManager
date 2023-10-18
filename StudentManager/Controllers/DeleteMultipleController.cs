using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManager.BackgroundServices;
using StudentManager.Contracts;
using StudentManager.Models;

namespace StudentManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteMultipleController : ControllerBase
    {
        private readonly RecordDeletionService _deletionService;
        public DeleteMultipleController(RecordDeletionService deletionService)
        {
            _deletionService = deletionService;
            
        }

        [HttpDelete("delete-multiple")]
        public IActionResult DeleteMultipleRecords([FromBody] List<Guid> recordIds)
        {
            // Enqueue the deletion task to be processed in the background
            _deletionService.EnqueueRecordIds(recordIds);

            // Return immediate response to the client
            return Accepted();
        }
        }
}
