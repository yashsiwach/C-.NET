namespace ScenrioProject3
{
    #region Robot Hazard Auditor Class

    /// <summary>
    /// RobotHazardAuditor evaluates industrial robot safety risk
    /// based on precision, worker density, and machinery state.
    /// </summary>
    public class RobotHazardAuditor
    {
        #region Data Members

        public double armPrecision { get; set; }
        public int workerDensity { get; set; }
        public string? machineryState { get; set; }
        public double Risk { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates hazard risk using validation rules
        /// and predefined risk factors.
        /// </summary>
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            if (armPrecision <= 0 || armPrecision >= 1.0)
            {
                throw new RobotSafetyExceptionwith("Error: Arm precision must be 0.0-1.0");
            }

            if (workerDensity < 1 || workerDensity > 20)
            {
                throw new RobotSafetyExceptionwith("Error: Worker density must be 1-20");
            }

            if (!(machineryState.Equals("Worn") ||
                  machineryState.Equals("Faulty") ||
                  machineryState.Equals("Critical")))
            {
                throw new RobotSafetyExceptionwith("Error: Unsupported machinery state");
            }

            double machineRiskFactor = 0.0;

            if (machineryState.Equals("Worn"))
            {
                machineRiskFactor = 1.3;
            }
            else if (machineryState.Equals("Faulty"))
            {
                machineRiskFactor = 2.0;
            }
            else
            {
                machineRiskFactor = 3.0;
            }

            this.Risk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
            return this.Risk;
        }

        #endregion
    }

    #endregion
}
