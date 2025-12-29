namespace ScenrioProject4.PayRollPro
{
    #region Employee Base Class

    /// <summary>
    /// EmployeeRecord is an abstract base class
    /// that defines common payroll data and
    /// enforces monthly pay calculation logic.
    /// </summary>
    public abstract class EmployeeRecord
    {
        #region Data Members

        public string? EmployeeName { get; set; }
        public double[] WeeklyHours { get; set; }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// Calculates the monthly pay for an employee.
        /// Must be implemented by derived classes.
        /// </summary>
        public abstract double GetMonthlyPay();

        #endregion
    }

    #endregion
}
