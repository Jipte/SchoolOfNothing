using SchoolOfNothing.Models;

namespace SchoolOfNothing.repository.Repositories.StudentRepository
{
    public interface IStudentRepository
    {
        Task create(StudentModel model);

        Task<IList<StudentModel>> ReadAll();

        Task<StudentModel> Read(Guid id);
    }
}
