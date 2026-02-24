using emptyCore.Models;

namespace emptyCore.Repository
{
    public class StudentRepository : IStudent
    {
        private List<Student> students=new List<Student>
            {
                new Student { Id = 1, Name = "John", Age = 20 },
                new Student { Id = 2, Name = "Jane", Age = 22 },
                new Student { Id = 3, Name = "Bob", Age = 21 }
    };
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(int id)
        {
            students.RemoveAll(s => s.Id == id);
        }

        public List<Student> GetAllStudents()
        {

            return Store();
        }
        private List<Student> Store()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "John", Age = 20 },
                new Student { Id = 2, Name = "Jane", Age = 22 },
                new Student { Id = 3, Name = "Bob", Age = 21 }
            };
        }
        public Student GetStudentById(int id)
       {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
