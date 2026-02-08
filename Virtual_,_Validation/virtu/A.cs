using System;
namespace Classwork
{
    /// <summary>
    /// example to learn overriding the methods 
    /// </summary>
    public class Father
    {
        public virtual string Interest()
        {
            return "criket";
        }
    }
    public class Son: Father
    {
        public override string Interest()
        {
            return "cartoon";
        }
    }
}