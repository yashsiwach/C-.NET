namespace ScenrioProject4.PayRollPro
{
    #region Contract Employee Class

    /// <summary>
    /// ContractEmployee represents a contract-based employee
    /// whose monthly pay is calculated using hourly rate
    /// and total worked hours.
    /// </summary>
    public class ContractEmployee : EmployeeRecord
    {
        #region Data Members

        public double HourlyRate { get; set; }

        #endregion

        #region Constructors

        public ContractEmployee(string name, double[] arr, double HourlyRate)
        {
            this.EmployeeName = name;
            this.WeeklyHours = arr;
            this.HourlyRate = HourlyRate;
        }

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Calculates monthly pay based on
        /// total worked hours and hourly rate.
        /// </summary>
        public override double GetMonthlyPay()
        {
            double sum = 0;

            foreach (var i in WeeklyHours)
            {
                sum += i;
            }

            return (sum * HourlyRate);
        }

        #endregion
    }

    #endregion
}
