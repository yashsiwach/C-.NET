using System;
namespace Con{
public class A
{
    public string? name {get;set;}
    
    private A()
    {
        
    }
    public A(string name)
    {
        this.name=name;
    }
}
}