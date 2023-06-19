namespace Metigator.OOP012.WithoutInInheritence
{
    public class SalesAgent
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal HourlyRate { get; set; }
        public int ExpectedHours { get; set; }
        public int LoggedHours { get; set; }
        public decimal TotalSales { get; set; }

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

        private decimal CalculateCommissionAmount()
        {
            return TotalSales * HRConstants.CommissionRate;
        }

        private decimal CalculateGrossPay()
        {
            return CalculateBasicSalary() + CalculateOvertimeAmount() + CalculateCommissionAmount();
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
            decimal commission = CalculateCommissionAmount();

            return $"Employee: #{Id} ({FullName}).\n" +
            $"Hours Logged: {LoggedHours} hrs.\n" +
            $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
            $"Basic Salary: {basicSalary.ToString("C")}\n" +
            $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
            $"Total Sales: {TotalSales.ToString("C")}\n" +
            $"Commission({(HRConstants.CommissionRate).ToString("%0")}): {commission.ToString("C")}\n" +
            $"Gross Pay: {grossSalary.ToString("C")}\n" +
            $"Tax Amount ({(HRConstants.TaxRate).ToString("%0")}): {taxAmount.ToString("C")}\n" +
            $"-------------------------------------\n" +
            $"Net Salary: {netSalary.ToString("C")}";
        }
    }
}