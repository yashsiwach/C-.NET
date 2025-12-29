namespace ScenrioProject4.PayRollPro
{
    public class FullTimeEmployee : EmployeeRecord
    {
        public double HourlyRate{get;set;}
        public double MonthlyBonus{get;set;}
        public FullTimeEmployee(string name,double[] arr,double HourlyRate,double MonthlyBonus)
        {
            this.EmployeeName=name;
            this.WeeklyHours=arr;
            this.HourlyRate=HourlyRate;
            this.MonthlyBonus=MonthlyBonus;
        }
        public override double GetMonthlyPay()
        {
            double sum=0;
            foreach(var i in WeeklyHours)
            {
                sum+=i;
            }
            return ((sum*HourlyRate)+MonthlyBonus);
        }
    }
}