# PRD Document - Salary Calculation System

## Overview
>The Salary Calculation System is designed to calculate the net salary for different employee roles based on their specific attributes and rules. The system supports the following employee roles: Manager, Sales Agent, Handyman, and Software Engineer.

>يهدف نظام حساب الرواتب إلى حساب الرواتب الصافية لأدوار الموظفين المختلفة استنادًا إلى سماتهم والقواعد الخاصة بهم. يدعم النظام الأدوار التالية: مدير، وكيل مبيعات، حرفي، ومهندس برمجيات.

## Features

### Manager

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
    
    public decimal CalculateNetSalary()
    {
       // • Calculate gross salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Add Allowance to the salary أضف البدل إلى الراتب
       // • Deduct income tax خصم ضريبة الدخل (Tax rate is 10%)
       // • Calculate net salary احسب الراتب الصافي
    }
}
```

### Sales Agent

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
    public decimal Commission { get; set; }

    public decimal CalculateNetSalary()
    {
       // • Calculate gross salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Calculate Commission  احسب العمولة (TotalSales * Commission)
       // • Deduct income tax خصم ضريبة الدخل (Tax rate is 10%)
       // • Calculate net salary احسب الراتب الصافي
    }
}
```

### Handyman
#### Attributes
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

    public decimal CalculateNetSalary()
    {
       // • Calculate gross salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Add Hardship اضف صعوبة العمل  (fixed amount of $75)
       // • Deduct income tax خصم ضريبة الدخل (Tax rate is 10%)
       // • Calculate net salary احسب الراتب الصافي
    }
}
```
#### Salary Calculation
```csharp
public decimal CalculateNetSalary(Handyman handyman)
{
    decimal grossSalary = handyman.HourlyRate * handyman.LoggedHours;
    decimal overtime = (handyman.LoggedHours > handyman.ExpectedHours) ? (handyman.LoggedHours - handyman.ExpectedHours) * handyman.HourlyRate * 1.5m : 0;
    decimal salaryBeforeTax = grossSalary + overtime + handyman.Hardship;
    decimal tax = salaryBeforeTax * 0.10m;
    return salaryBeforeTax - tax;
}
```

### Software Engineer
#### Attributes
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

    public decimal CalculateNetSalary()
    {
       // • Calculate gross salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Add Training Allowance اضف بدل تدريب  (fixed amount of $50)
       // • Add Bonus Allowance اضف بدل تدريب  (add $40 when complete 8 user story or above)
       // • Deduct income tax خصم ضريبة الدخل (Tax rate is 10%)
       // • Calculate net salary احسب الراتب الصافي
    }
}
```
