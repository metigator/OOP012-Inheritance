namespace Metigator.OOP012.WithInheritence
{
    public sealed class SoftwareEngineer : Employee
    {
        public decimal TrainingAllowance { get; set; }
        public int StoryPointCompleted { get; set; }

        protected override decimal CalculateGrossPay()
        {
            return base.CalculateGrossPay() + CalculateBonusAmount() + TrainingAllowance;
        }

        private decimal CalculateBonusAmount()
        {
            return StoryPointCompleted >= HRConstants.SoftwareEngineerStoryPointThreshold
                   ? HRConstants.SoftwareEngineerBonusAmount
                   : 0;
        }


        public override string ShowSalarySlip()
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
            $"Tax Amount ({HRConstants.TaxRate.ToString("%0")}): {taxAmount.ToString("C")}\n" +
            $"-------------------------------------\n" +
            $"Net Salary: {netSalary.ToString("C")}";
        }


    }
}