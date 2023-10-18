using System.ComponentModel.DataAnnotations;

namespace StudentManager.Utilities.Dto
{
    public class StudentAddRequest
    {
        [Required(ErrorMessage = "Name field can't be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of  Birth filed can't be empty")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "You have to chose a class")]
        public int ClassId { get; set; }
        [Required(ErrorMessage = "You have to chose a Gender")]
        public int GenderId { get; set; }
    }
}
