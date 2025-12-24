namespace Project1
{
    /// <summary>
    /// Creating the Examiner 
    /// </summary>
    public class Examiner : Employe
    {
        
        #region Class Varibles
        public int exId;
        public string? exName;
        #endregion

        #region Methods
        /// <summary>
        /// Creates an examiner by taking employee details from the user
        /// and assigning the examiner to the exam.
        /// </summary>
        /// <variables>
        /// eid    : Employee ID entered by the user.
        /// ename  : Employee name entered by the user.
        /// exId   : Stores the examiner's employee ID.
        /// exName : Stores the examiner's name.
        /// </variables>
        public Examiner()
        {
            System.Console.WriteLine("enter employe id");
            int eid = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("enter emplye Name");
            string? ename = Console.ReadLine();
            this.exId = eid;
            this.exName = ename;
            IsAssigned();
        }
        public void IsAssigned()
        {
            System.Console.WriteLine("assigned");
        }
        #endregion
    }

}