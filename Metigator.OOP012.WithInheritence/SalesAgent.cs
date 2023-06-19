namespace Metigator.OOP012.WithInheritence
{
    public sealed class SalesAgent : Employee
    {
        public decimal TotalSales { get; set; }

        private decimal CalculateCommissionAmount()
        {
            return TotalSales * HRConstants.CommissionRate;
        }
        protected override decimal CalculateGrossPay()
        {
            return base.CalculateGrossPay() + CalculateCommissionAmount();
        }


        public override string ShowSalarySlip()
        {
            decimal basicSalary = CalculateBasicSalary();
            decimal grossSalary = CalculateGrossPay();
            decimal taxAmount = CalculateTaxAmount();
            decimal netSalary = CalculateNetSalary();
            decimal overtime = CalculateOvertimeAmount();
            decimal commission = CalculateCommissionAmount();

            return $"Employee: #{Id} ({FullName}).\n" +
            $"Hours Logged: {LoggedHours} hrs.\n" +
            $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
            $"Basic Salary: {basicSalary.ToString("C")}\n" +
            $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
            $"Total Sales: {TotalSales.ToString("C")}\n" +
            $"Commission({HRConstants.CommissionRate.ToString("%0")}): {commission.ToString("C")}\n" +
            $"Gross Pay: {grossSalary.ToString("C")}\n" +
            $"Tax Amount ({HRConstants.TaxRate.ToString("%0")}): {taxAmount.ToString("C")}\n" +
            $"-------------------------------------\n" +
            $"Net Salary: {netSalary.ToString("C")}";
        }
    }
}