using StudentManager.Models;

namespace StudentManager.Utilities.Specifications
{
    public class StudentsWithClassAndSortSpecification : BaseSpecification<Student>
    {
        public StudentsWithClassAndSortSpecification(StudentsSpecPerams specPerams): base(student =>
        (string.IsNullOrEmpty(specPerams.Search) || (student.Name.ToLower().Contains(specPerams.Search))))
        {
            AddInclude(student => student.Class);
            AddInclude(student => student.Gender);
            AddOrderBy(student => student.Name);
            ApplyPaging(specPerams.PageSize * (specPerams.PageIndex - 1), specPerams.PageSize);
            if (!string.IsNullOrEmpty(specPerams.Sort))
            {
                switch (specPerams.Sort)
                {
                    case "nameAsc":
                        AddOrderBy(s => s.Name);
                        break;
                    case "nameDesc":
                        AddOrderByDescending(s => s.Name);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }
        public StudentsWithClassAndSortSpecification(Guid id) : base(student=>student.Id == id)
        {
            AddInclude(student => student.Class);
            AddInclude(student => student.Gender);
        }
    }
}
