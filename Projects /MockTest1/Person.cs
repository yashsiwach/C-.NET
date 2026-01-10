namespace Mock1
{
    public class Person
    {

        public Person(string name,string Address,int age)
        {
            this.Name=name;
            this.Address=Address;
            this.Age=age;
        }
        public string? Name{get;set;}
        public string? Address{get;set;}
        public int Age{get;set;}
    }
}