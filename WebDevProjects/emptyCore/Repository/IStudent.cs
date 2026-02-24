using emptyCore.Models;

namespace emptyCore.Repository
{
    public interface IStudent
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void DeleteStudent(int id);
    }
}
