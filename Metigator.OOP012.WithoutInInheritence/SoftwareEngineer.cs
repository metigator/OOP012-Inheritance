namespace Metigator.OOP012.WithoutInInheritence
{
    public class SoftwareEngineer
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal HourlyRate { get; set; }
        public int ExpectedHours { get; set; }
        public int LoggedHours { get; set; }
        public decimal TrainingAllowance { get; set; }
        public int StoryPointCompleted { get; set; }

        public string FullName => $"{FName} {LName}";

        private decimal CalculateBasicSalary()
        {
            int hoursDeviation = LoggedHours - ExpectedHours; // +/-  
            int regularHours = LoggedHours - Math.Max(hoursDeviation, 0);
            return regularHours * HourlyRate;
        }

        private decimal CalculateOvertimeAmount()
        {
            int hoursDeviation = LoggedHours - ExpectedHours;
            return Math.Max(hoursDeviation, 0) * HRConstants.OvertimeRate * HourlyRate;
        }

        private decimal CalculateBonusAmount()
        {
            return StoryPointCompleted >= HRConstants.SoftwareEngineerStoryPointThreshold
                   ? HRConstants.SoftwareEngineerBonusAmount
                   : 0;
        }

        private decimal CalculateGrossPay()
        {
            return CalculateBasicSalary() + CalculateOvertimeAmount() + CalculateBonusAmount() + TrainingAllowance;
        }

        private decimal CalculateTaxAmount()
        {
            return CalculateGrossPay() * HRConstants.TaxRate;
        }

        private decimal CalculateNetSalary()
        {
            return CalculateGrossPay() - CalculateTaxAmount();
        }

        public string ShowSalarySlip()
        {
            decimal basicSalary = CalculateBasicSalary();
            decimal grossSalary = CalculateGrossPay();
            decimal taxAmount = CalculateTaxAmount();
            decimal netSalary = CalculateNetSalary();
            decimal overtime = CalculateOvertimeAmount();
            decimal bonus = CalculateBonusAmount();

            return $"Employee: #{Id} ({FullName}).\n" +
            $"Hours Logged: {LoggedHours} hrs.\n" +
            $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
            $"Basic Salary: {basicSalary.ToString("C")}\n" +
            $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
            $"Training Allowance: {TrainingAllowance.ToString("C")}\n" +
            $"Bonus(>={HRConstants.SoftwareEngineerStoryPointThreshold}): {bonus.ToString("C")}\n" +
            $"Gross Pay: {grossSalary.ToString("C")}\n" +
            $"Tax Amount ({(HRConstants.TaxRate).ToString("%0")}): {taxAmount.ToString("C")}\n" +
            $"-------------------------------------\n" +
            $"Net Salary: {netSalary.ToString("C")}";
        }


    }
}