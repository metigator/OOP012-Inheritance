namespace Metigator.OOP012.WithInheritence
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Employee manager = new Manager
            //{
            //    Id = 1001,
            //    FName = "Ahmad",
            //    LName = "Salem",
            //    HourlyRate = 10.0m,
            //    ExpectedHours = 40,
            //    LoggedHours = 40,
            //    Allowance = 100,
            //};
            //Console.WriteLine("------ Manager ---------");
            //Console.WriteLine(manager.ShowSalarySlip());
            //Console.WriteLine();

            //Employee salesAgent = new SalesAgent
            //{
            //    Id = 1002,
            //    FName = "Reem",
            //    LName = "Abdallah",
            //    HourlyRate = 10.0m,
            //    ExpectedHours = 40,
            //    LoggedHours = 45,
            //    TotalSales = 10000
            //};
            //Console.WriteLine("------ Sales Agent ---------");
            //Console.WriteLine(salesAgent.ShowSalarySlip());
            //Console.WriteLine();

            //Employee handyman = new Handyman
            //{
            //    Id = 1003,
            //    FName = "Salah",
            //    LName = "Adel",
            //    HourlyRate = 5.0m,
            //    ExpectedHours = 40,
            //    LoggedHours = 65,
            //    Hardship = 75,
            //};
            //Console.WriteLine("------ Handyman ---------");
            //Console.WriteLine(handyman.ShowSalarySlip());
            //Console.WriteLine();

            //Employee softwareEngineer = new SoftwareEngineer
            //{
            //    Id = 1004,
            //    FName = "Madiha",
            //    LName = "Rawi",
            //    HourlyRate = 10.0m,
            //    ExpectedHours = 40,
            //    LoggedHours = 40,
            //    TrainingAllowance = 50,
            //    StoryPointCompleted = 8
            //};
            //Console.WriteLine("------ Software Engineer ---------");
            //Console.WriteLine(softwareEngineer.ShowSalarySlip());
            //Console.WriteLine();


            List<Employee> employees = new()
            {
                new Manager
                {
                    Id = 1001,
                    FName = "Ahmad",
                    LName = "Salem",
                    HourlyRate = 10.0m,
                    ExpectedHours = 40,
                    LoggedHours = 40,
                    Allowance = 100,
                },
                new SalesAgent
                {
                    Id = 1002,
                    FName = "Reem",
                    LName = "Abdallah",
                    HourlyRate = 10.0m,
                    ExpectedHours = 40,
                    LoggedHours = 45,
                    TotalSales = 10000
                },
                new Handyman
                {
                    Id = 1003,
                    FName = "Salah",
                    LName = "Adel",
                    HourlyRate = 5.0m,
                    ExpectedHours = 40,
                    LoggedHours = 65,
                    Hardship = 75,
                },
                new SoftwareEngineer
                {
                    Id = 1004,
                    FName = "Madiha",
                    LName = "Rawi",
                    HourlyRate = 10.0m,
                    ExpectedHours = 40,
                    LoggedHours = 40,
                    TrainingAllowance = 50,
                    StoryPointCompleted = 8
                }
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"------ {employee.GetType().Name} ---------");
                Console.WriteLine(employee.ShowSalarySlip());
                Console.WriteLine();
            }
        }
    }
}