public interface IPerson
{
    string GetName();
    void SetName(string name);
}

public class Student : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string GetName()
    {
        return this.Name;
    }

    public void SetName(string name)
    {
        this.Name = name;
    }
}
