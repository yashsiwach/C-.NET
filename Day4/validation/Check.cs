using System;
namespace Valid
{
    public class Check
    {
        int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Must be positive");
                id = value;

            }
        }
        private string name;
        public string? Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Must be not Null");
                else if (value.Length < 3)

                    throw new ArgumentException("should not be less than 3");
                name = value;

            }
        }
        string? rank;
        public string? Rank
        {
            get { return rank; }
            set
            {
                if (value == null)
                    throw new ArgumentException("should not be null");
                else if (value == "manager" || value == "intern")
                    rank=value;
                else
                {
                    throw new ArgumentException(" outsider");
                }
            }

            

        }
    }

    // public Check(int Id, string Name,string Rank)
    // {
    //     this.Id=Id;
    //     this.Name=Name;
    //     this.Rank=Rank;
    // }
}
