[TestFixture]
public class StudentTests
{
    public Student student;

    [SetUp]
    public void Setup()
    {
        student = new Student();
    }

    [Test]
    public void SetName_ThenGetName_ReturnsSameName()
    {
        student.SetName("Yash");
        string result = student.GetName();
        Assert.AreEqual("Yash", result);
    }
}
