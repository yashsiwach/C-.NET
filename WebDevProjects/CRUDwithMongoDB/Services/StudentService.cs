using MongoCrudApp.Models;
using MongoDB.Driver;
namespace CRUDwithMongoDB.Services
{
    public class StudentService
    {
        
        private readonly IMongoCollection<Student> _students;
        public StudentService(IConfiguration config) 
        {
            var client = new MongoClient(config["MongoDbSettings:cs"]);
            var database = client.GetDatabase("school");
            _students = database.GetCollection<Student>("students");
        }
        public List<Student> Get() => _students.Find(student => true).ToList();
        public Student Get(string id) => _students.Find<Student>(student => student.Id == id).FirstOrDefault();
        public Student Create(Student student)
        {
            _students.InsertOne(student);
            return student;
        }
        public void Update(string id, Student studentIn) => _students.ReplaceOne(student => student.Id == id, studentIn);
        public void Delete(Student studentIn) => _students.DeleteOne(student => student.Id == studentIn.Id);
    }
}
