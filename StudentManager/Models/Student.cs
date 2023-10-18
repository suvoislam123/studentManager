using System.ComponentModel.DataAnnotations;

namespace StudentManager.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ClassId { get; set; }    
        public Class Class { get; set; } 
        public int GenderId { get; set; }
        public Gender Gender { get; set; } 
    }
}
