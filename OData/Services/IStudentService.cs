using OData.Models;

namespace OData.Services
{
    public interface IStudentService
    {
        IQueryable<Student> ListAllStudents();
    }
}
