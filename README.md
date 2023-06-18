# PRD Document - Salary Calculation System

## Overview
>The Salary Calculation System is designed to calculate the net salary for different employee roles based on their specific attributes and rules. The system supports the following employee roles: Manager, Sales Agent, Handyman, and Software Engineer.

>يهدف نظام حساب الرواتب إلى حساب الرواتب الصافية لأدوار الموظفين المختلفة استنادًا إلى سماتهم والقواعد الخاصة بهم. يدعم النظام الأدوار التالية: مدير، وكيل مبيعات، حرفي، ومهندس برمجيات.
![image](https://github.com/metigator/OOP012-Inheritance/assets/87314838/32868c85-c572-4936-91c2-4101b8655284)




## Features

### Manager

The `Manager` class represents a manager employee.

- `Id` (Integer): The employee's ID.
- `FName` (String): The employee's first name.
- `LName` (String): The employee's last name.
- `HourlyRate` (Decimal): The hourly rate of the manager.
- `ExpectedHours` (Integer): The expected number of work hours for the manager.
- `LoggedHours` (Integer): The actual number of work hours logged by the manager.
- `Allowance` (Decimal): Any additional allowance added to the manager's salary.

##### Manager Class
```csharp
public class Manager
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public decimal HourlyRate { get; set; }
    public int ExpectedHours { get; set; }
    public int LoggedHours { get; set; }
    public decimal Allowance { get; set; }

    public string ShowSalarySlip()
    {
        decimal basicSalary = 0;
        decimal grossSalary = 0;
        decimal taxAmount = 0;
        decimal netSalary = 0;
        decimal overtime = 0;

        return $"Employee: #{Id} ({FullName}).\n" +
        $"Hours Logged: {LoggedHours} hrs.\n" +
        $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
        $"Basic Salary: {basicSalary.ToString("C")}\n" +
        $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
        $"Allowance: {Allowance.ToString("C")}\n" +
        $"Gross Pay: {grossSalary.ToString("C")}\n" +
        $"Tax Amount ({(HRConstants.TaxRate).ToString("%0")}): {taxAmount.ToString("C")}\n" +
        $"-------------------------------------\n" +
        $"Net Salary: {netSalary.ToString("C")}";
    }
}
```

### Sales Agent

## SalesAgent Class

The `SalesAgent` class represents a sales agent employee.


- `Id` (Integer): The employee's ID.
- `FName` (String): The employee's first name.
- `LName` (String): The employee's last name.
- `HourlyRate` (Decimal): The hourly rate of the sales agent.
- `ExpectedHours` (Integer): The expected number of work hours for the sales agent.
- `LoggedHours` (Integer): The actual number of work hours logged by the sales agent.
- `TotalSales` (Decimal): The total sales amount achieved by the sales agent.

##### SalesAgent Class
```csharp
public class SalesAgent
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public decimal HourlyRate { get; set; }
    public int ExpectedHours { get; set; }
    public int LoggedHours { get; set; }
    public decimal TotalSales { get; set; }
    
    public string ShowSalarySlip()
    {
        decimal basicSalary = 0;
        decimal grossSalary = 0;
        decimal taxAmount = 0;
        decimal netSalary = 0;
        decimal overtime = ;
        decimal commission = ;

        return $"Employee: #{Id} ({FullName}).\n" +
        $"Hours Logged: {LoggedHours} hrs.\n" +
        $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
        $"Basic Salary: {basicSalary.ToString("C")}\n" +
        $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
        $"Commission({(HRConstants.CommissionRate).ToString("%0")}): {commission.ToString("C")}\n"+
        $"Gross Pay: {grossSalary.ToString("C")}\n" +
        $"Tax Amount ({(HRConstants.TaxRate).ToString("%0")}): {taxAmount.ToString("C")}\n" +
        $"-------------------------------------\n" +
        $"Net Salary: {netSalary.ToString("C")}";
    }
}
```

### Handyman

The `Handyman` class represents a handyman employee.


- `Id` (Integer): The employee's ID.
- `FName` (String): The employee's first name.
- `LName` (String): The employee's last name.
- `HourlyRate` (Decimal): The hourly rate of the handyman.
- `ExpectedHours` (Integer): The expected number of work hours for the handyman.
- `LoggedHours` (Integer): The actual number of work hours logged by the handyman.
- `Hardship` (Decimal): An additional hardship allowance for the handyman.


```csharp
public class Handyman
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public decimal HourlyRate { get; set; }
    public int ExpectedHours { get; set; }
    public int LoggedHours { get; set; }
    public decimal Hardship { get; set; }
    
    public string ShowSalarySlip()
    {
        decimal basicSalary = 0;
        decimal grossSalary = 0;
        decimal taxAmount = 0;
        decimal netSalary = 0;
        decimal overtime = 0;

        return $"Employee: #{Id} ({FullName}).\n" +
        $"Hours Logged: {LoggedHours} hrs.\n" +
        $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
        $"Basic Salary: {basicSalary.ToString("C")}\n" +
        $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
        $"Hardship: {Hardship.ToString("C")}\n" +
        $"Gross Pay: {grossSalary.ToString("C")}\n" +
        $"Tax Amount ({(HRConstants.TaxRate).ToString("%0")}): {taxAmount.ToString("C")}\n" +
        $"-------------------------------------\n" +
        $"Net Salary: {netSalary.ToString("C")}";
    }
}
```
### Software Engineer

The `SoftwareEngineer` class represents a software engineer employee.

### Properties

- `Id` (Integer): The employee's ID.
- `FName` (String): The employee's first name.
- `LName` (String): The employee's last name.
- `HourlyRate` (Decimal): The hourly rate of the software engineer.
- `ExpectedHours` (Integer): The expected number of work hours for the software engineer.
- `LoggedHours` (Integer): The actual number of work hours logged by the software engineer.
- `TrainingAllowance` (Decimal): The training allowance amount for the software engineer.
- `StoryPointCompleted` (Integer): The number of story points completed by the software engineer.

```csharp
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

    public string ShowSalarySlip()
    {
        decimal basicSalary = CalculateBasicSalary();
        decimal grossSalary = CalculateGrossPayAmount();
        decimal taxAmount = CalculateTaxAmount();
        decimal netSalary = CalculateNetSalary();
        decimal overtime = CalculateOvertimeAmount();
        decimal bonus = CalculateBonus();

        return $"Employee: #{Id} ({FullName}).\n" +
        $"Hours Logged: {LoggedHours} hrs.\n" +
        $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
        $"Basic Salary: {basicSalary.ToString("C")}\n" +
        $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
        $"Training Allowance: {TrainingAllowance.ToString("C")}\n" +
        $"Bonus(>={(HRConstants.SoftwareEngineerStoryPointThreshold)}): Bonus.ToString("C")}\n" +
        $"Gross Pay: {grossSalary.ToString("C")}\n" +
        $"Tax Amount ({(HRConstants.TaxRate).ToString("%0")}): {taxAmount.ToString("C")}\n" +
        $"-------------------------------------\n" +
        $"Net Salary: {netSalary.ToString("C")}";
    }
}
```
