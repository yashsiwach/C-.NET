namespace Mock1
{
    public class PersonImplematation
    {
        public string GetName(IList<Person> person)
        {
            string ans="";
            foreach(var i in person)
            {
                ans += i.Name;
                ans += " ";
                ans += i.Address;
                ans += " ";
            }
            return ans;
        }
        public double Average(IList<Person> person)
        {
            int count=0;
            int total=0;
            foreach(var i in person)
            {
                count+=i.Age;
                total++;
            }
            return count/total;
            
        }
        public double Maxi(IList<Person> person)
        {
            int maxi=0;
            foreach(var i in person)
            {
                maxi=Math.Max(i.Age,maxi);
            }
            return maxi;
        }
    }
}