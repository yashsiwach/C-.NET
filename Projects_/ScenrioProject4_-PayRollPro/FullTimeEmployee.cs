namespace ScenrioProject4.PayRollPro
{
    #region Full-Time Employee Class

    /// <summary>
    /// FullTimeEmployee represents a permanent employee
    /// whose monthly pay includes hourly wages
    /// along with a fixed monthly bonus.
    /// </summary>
    public class FullTimeEmployee : EmployeeRecord
    {
        #region Data Members

        public double HourlyRate { get; set; }
        public double MonthlyBonus { get; set; }

        #endregion

        #region Constructors

        public FullTimeEmployee(
            string name,
            double[] arr,
            double HourlyRate,
            double MonthlyBonus
        )
        {
            this.EmployeeName = name;
            this.WeeklyHours = arr;
            this.HourlyRate = HourlyRate;
            this.MonthlyBonus = MonthlyBonus;
        }

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Calculates monthly pay by summing
        /// weekly hours, multiplying by hourly rate,
        /// and adding the monthly bonus.
        /// </summary>
        public override double GetMonthlyPay()
        {
            double sum = 0;

            foreach (var i in WeeklyHours)
            {
                sum += i;
            }

            return ((sum * HourlyRate) + MonthlyBonus);
        }

        #endregion
    }

    #endregion
}
