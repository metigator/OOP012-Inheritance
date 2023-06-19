namespace Metigator.OOP012.WithInheritence
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal HourlyRate { get; set; }
        public int ExpectedHours { get; set; }
        public int LoggedHours { get; set; }

        public string FullName => $"{FName} {LName}";


        protected decimal CalculateBasicSalary()
        {
            int hoursDeviation = LoggedHours - ExpectedHours; // +/-  
            int regularHours = LoggedHours - Math.Max(hoursDeviation, 0);
            return regularHours * HourlyRate;
        }
        protected decimal CalculateOvertimeAmount()
        {
            int hoursDeviation = LoggedHours - ExpectedHours;
            return Math.Max(hoursDeviation, 0) * HRConstants.OvertimeRate * HourlyRate;
        }

        protected virtual decimal CalculateGrossPay()
        {
            return CalculateBasicSalary() + CalculateOvertimeAmount();
        }

        protected decimal CalculateTaxAmount()
        {
            return CalculateGrossPay() * HRConstants.TaxRate;
        }

        protected decimal CalculateNetSalary()
        {
            return CalculateGrossPay() - CalculateTaxAmount();
        }

        public abstract string ShowSalarySlip();
    }
}
