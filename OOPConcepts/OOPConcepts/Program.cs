// See https://aka.ms/new-console-template for more information

using OOPConcepts;

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Richard",
    LastName = "Rodriguez",
    BirthDate = new Date(1981, 7, 10),
    HiringDate = new Date(2023, 2, 10),
    Salary = 1080
};
Employee employee2 = new CommisionEmployee()
{
    Id = 2020,
    FirstName = "Anicacia",
    LastName = "Cuello",
    BirthDate = new Date(1958, 12, 15),
    HiringDate = new Date(2020, 5, 14),
    IsActive = true,
    CommisionPercentaje = 0.23f,
    Sales = 150
};
Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Virginia",
    LastName = "Gil-Alfaro",
    BirthDate = new Date(1983, 11, 15),
    HiringDate = new Date(2020, 5, 14),
    IsActive = true,
    Hours = 40,
    HourValue = 3M,

};
Employee employee4 = new BaseCommisionEmployee()
{
    Id = 4040,
    FirstName = "Jose miguel",
    LastName = "Rodriguez Cuello",
    BirthDate = new Date(1986, 3, 18),
    HiringDate = new Date(2022, 12, 1),
    IsActive = true,
    Base = 1200,
    Sales = 40,
    CommisionPercentaje = 0.15F
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1,employee2, employee3, employee4
};
decimal payRoll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payRoll += employee.GetValueToPay();
}
Console.WriteLine("                             ===========");
Console.WriteLine($"TOTAL                         {payRoll:C2}");

Invoice invoice = new Invoice()
{
    Id = 1234,
    Descripcion = "iphone 14",
    Quantity = 1,
    Price = 1150
};

Console.WriteLine(invoice);