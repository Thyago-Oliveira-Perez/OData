using OData.Models;

namespace OData.Services
{
    public class StudentService : IStudentService
    {

        public IQueryable<Student> ListAllStudents()
        {
            return new List<Student>{
                new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = "Maria",
                    Grade = 80
                },
                new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = "Clara",
                    Grade = 75
                },
                new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = "Rafaela",
                    Grade = 100
                }
            }.AsQueryable();   
        }
    }
}
