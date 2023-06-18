# PRD Document - Salary Calculation System

## Overview
>The Salary Calculation System is designed to calculate the net salary for different employee roles based on their specific attributes and rules. The system supports the following employee roles: Manager, Sales Agent, Handyman, and Software Engineer.

>يهدف نظام حساب الرواتب إلى حساب الرواتب الصافية لأدوار الموظفين المختلفة استنادًا إلى سماتهم والقواعد الخاصة بهم. يدعم النظام الأدوار التالية: مدير، وكيل مبيعات، حرفي، ومهندس برمجيات.
 ![image](https://github.com/metigator/OOP012-Inheritance/assets/87314838/f9bf8d98-1e58-4a4b-9ca7-463ed449d66b)




## Features

### Manager

The `Manager` class represents a manager employee.


### Properties

- `Id` (Integer): The employee's ID.
- `FName` (String): The employee's first name.
- `LName` (String): The employee's last name.
- `HourlyRate` (Decimal): The hourly rate of the manager.
- `ExpectedHours` (Integer): The expected number of work hours for the manager.
- `LoggedHours` (Integer): The actual number of work hours logged by the manager.
- `Allowance` (Decimal): Any additional allowance added to the manager's salary.

### Methods

#### `CalculateNetSalary()`

>Calculates the gross salary based on the hourly rate and the expected number of work hours.
Determines the overtime pay for any hours exceeding the expected number of work hours.
Adds the allowance to the salary.
Deducts the income tax from the gross salary. The tax rate is fixed at 10%.
Calculates the net salary after deducting the taxes.

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

    public decimal CalculateNetSalary()
    {
       // • Calculate basic salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Add Allowance to the salary أضف البدل إلى الراتب
       // * Calculate Gross Salary
       // • Deduct income tax خصم ضريبة الدخل (Tax rate is 10%)
       // • Calculate net salary احسب الراتب الصافي
    }
}
```

### Sales Agent

## SalesAgent Class

The `SalesAgent` class represents a sales agent employee.

### Properties

- `Id` (Integer): The employee's ID.
- `FName` (String): The employee's first name.
- `LName` (String): The employee's last name.
- `HourlyRate` (Decimal): The hourly rate of the sales agent.
- `ExpectedHours` (Integer): The expected number of work hours for the sales agent.
- `LoggedHours` (Integer): The actual number of work hours logged by the sales agent.
- `TotalSales` (Decimal): The total sales amount achieved by the sales agent.

### Methods

#### `CalculateNetSalary()`

>Calculates the gross salary based on the hourly rate and the expected number of work hours.
Calculates the commission based on the total sales amount achieved by the sales agent.
Adds the commission to the salary.
Deducts the income tax from the gross salary. The tax rate is fixed at 10%.
Calculates the net salary after deducting the taxes.

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

    public decimal CalculateNetSalary()
    {
       // • Calculate basic salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Calculate Commission  احسب العمولة (TotalSales * Commission)
       // * Calculate Gross Salary
       // • Deduct income tax خصم ضريبة الدخل (Tax rate is 10%)
       // • Calculate net salary احسب الراتب الصافي
    }
}
```

### Handyman

The `Handyman` class represents a handyman employee.

### Properties

- `Id` (Integer): The employee's ID.
- `FName` (String): The employee's first name.
- `LName` (String): The employee's last name.
- `HourlyRate` (Decimal): The hourly rate of the handyman.
- `ExpectedHours` (Integer): The expected number of work hours for the handyman.
- `LoggedHours` (Integer): The actual number of work hours logged by the handyman.
- `Hardship` (Decimal): An additional hardship allowance for the handyman.

### Methods

#### `CalculateNetSalary()`

>Calculates the gross salary based on the hourly rate and the expected number of work hours.
Determines the overtime pay for any hours exceeding the expected number of work hours.
Adds the hardship allowance to the salary.
Deducts the income tax from the gross salary. The tax rate is fixed at 10%.
Calculates the net salary after deducting the taxes.

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
       // • Calculate basic salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Add Hardship اضف صعوبة العمل  (fixed amount of $75)
       // * Calculate Gross Salary
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

### Methods

#### `CalculateNetSalary()`

>Calculates the gross salary based on the hourly rate and the expected number of work hours.
Determines the overtime pay for any hours exceeding the expected number of work hours.
Adds the training allowance to the salary.
Adds an additional amount of $40 to the salary if the number of story points completed is greater than or equal to 80.
Deducts the income tax from the gross salary. The tax rate is fixed at 10%.
Calculates the net salary after deducting the taxes.

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
       // • Calculate basic salary احسب الراتب الإجمالي (HourRate & ExpectedHours)
       // • Calculate overtime احسب العمل الإضافي ((LoggedHours - ExpectedHours ) X 1.5 X HourRate)
       // • Add Training Allowance اضف بدل تدريب  (fixed amount of $50)
       // • Add Bonus Allowance اضف بدل تدريب  (add $40 when complete 8 user story or above)
       // * Calculate Gross Salary
       // • Deduct income tax خصم ضريبة الدخل (Tax rate is 10%)
       // • Calculate net salary احسب الراتب الصافي
    }
}
```
