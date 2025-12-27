namespace Project1
{
    /// <summary>
    /// This class is used to create an Examiner
    /// </summary>
    public class Examiner : Employe
    {
        #region Class Varibles

        /// <summary>
        /// Stores examiner id
        /// </summary>
        public int exId;

        /// <summary>
        /// Stores examiner name
        /// </summary>
        public string? exName;

        #endregion

        #region Methods

        /// <summary>
        /// Default constructor that takes employee details
        /// and assigns the examiner to the exam
        /// </summary>
        public Examiner()
        {
            System.Console.WriteLine("Enter employee id: ");
            int eid = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Enter emplyee Name: ");
            string? ename = Console.ReadLine();

            this.exId = eid;
            this.exName = ename;

            IsAssigned();
        }

        /// <summary>
        /// Displays confirmation message for examiner assignment
        /// </summary>
        public void IsAssigned()
        {
            System.Console.WriteLine("Assigned !!!");
        }

        #endregion
    }
}
