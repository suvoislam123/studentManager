using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentManager.Contracts;
using StudentManager.Models;
using StudentManager.Utilities.Dto;
using StudentManager.Utilities.Helper;
using StudentManager.Utilities.Specifications;

namespace StudentManager.Controllers
{
    
    public class StudentsController : Controller
    {
        private readonly IGenericRepository<Student> _studentsRepo;
        private readonly IGenericRepository<Class> _classRepo;
        private readonly IGenericRepository<Gender> _genderRepo;
        private readonly IMapper _mapper;
        public StudentsController(
            IGenericRepository<Student> studentRepo, 
            IGenericRepository<Class> classRepo,
            IGenericRepository<Gender> genderRepo,
            IMapper mapper)
        {
            _studentsRepo = studentRepo;
            _classRepo = classRepo;
            _genderRepo = genderRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<Pagination<StudentToReturnDto>>> GetStudents([FromQuery] StudentsSpecPerams specPerams)
        {
            //var specPerams = new StudentsSpecPerams();
            /*if (pageIndex.HasValue)
            {
                specPerams.PageIndex = (int)pageIndex;
            }*/
            var specification =  new StudentsWithClassAndSortSpecification(specPerams);
            var countSpec = new StudentWithFiltersForCountSpecification(specPerams);
            var totalItems = await _studentsRepo.CountAsync(countSpec);
            var students = await _studentsRepo.ListAsync(specification);
            var studentsDto = _mapper.Map<IReadOnlyList<Student>, IReadOnlyList<StudentToReturnDto>>(students);
            
            return View("Index",new Pagination<StudentToReturnDto>(specPerams.PageIndex,specPerams.Search, specPerams.PageSize, totalItems, studentsDto));
            //return Json(new Pagination<StudentToReturnDto>(specPerams.PageIndex, specPerams.PageSize, totalItems, studentsDto));
        }
        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await _studentsRepo.GetByIdAsync(id);

            return View(_mapper.Map<Student,StudentUpdateRequest>(student));
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpGet("Details")]
        public async Task<IActionResult> Details(Guid id)
        {
            var student = await _studentsRepo.GetByIdAsync(id);
            var cls = await _classRepo.GetByIdAsync(Guid.NewGuid(), student.ClassId);
            ViewData["class"] = cls.Name;
            var gender = await _genderRepo.GetByIdAsync(Guid.NewGuid(), student.ClassId);
            ViewData["gender"] = gender.Name;
            return View(_mapper.Map<Student,StudentToReturnDto>(student));
        }

        [HttpPost]
        public async Task<IActionResult> Update(StudentUpdateRequest studentUpdateRequest)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }
            var student = await _studentsRepo.GetByIdAsync(studentUpdateRequest.Id);
                student.Name= studentUpdateRequest.Name;
                student.GenderId = studentUpdateRequest.GenderId;
                student.ClassId = studentUpdateRequest.ClassId;
                student.DOB = studentUpdateRequest.DOB;
            student.ModifiedDate = DateTime.Now;
            _studentsRepo.Update(student);


            if (student != null)
            {
                return RedirectToAction("GetStudents");
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Add(StudentAddRequest studentAddRequest)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            var student = new Student()
            {
                Id  = Guid.NewGuid(),
                Name = studentAddRequest.Name,
                GenderId = studentAddRequest.GenderId,
                ClassId = studentAddRequest.ClassId,
                DOB = studentAddRequest.DOB,

            };
            
            _studentsRepo.Add(student);


            if (student != null)
            {
                return RedirectToAction("GetStudents");
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var student = await _studentsRepo.GetByIdAsync(id);
            _studentsRepo.Delete(student);
            return RedirectToAction("GetStudents");
        }



    }
}
