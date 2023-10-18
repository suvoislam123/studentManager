using StudentManager.Models;

namespace StudentManager.Utilities.Specifications
{
    public class StudentWithFiltersForCountSpecification : BaseSpecification<Student>
    {
        public StudentWithFiltersForCountSpecification(StudentsSpecPerams specPerams):base(student=>
        (string.IsNullOrEmpty(specPerams.Search) || (student.Name.ToLower().Contains(specPerams.Search))))
        {
            
        }
    }
}
