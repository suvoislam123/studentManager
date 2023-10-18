using StudentManager.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentManager.Utilities.Dto
{
    public class StudentToReturnDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
       
        public DateTime DOB { get; set; }
        
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }  
    }
}
