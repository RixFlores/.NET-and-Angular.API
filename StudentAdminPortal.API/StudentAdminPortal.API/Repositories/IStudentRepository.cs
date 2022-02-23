using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> getStudentsAsync();
        Task<Student> getStudentAsync(Guid studentId);
    }
}
