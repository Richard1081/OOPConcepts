// See https://aka.ms/new-console-template for more information

using OOPConcepts;

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Richard",
    LastName = "Rodriguez",
    BirthDate = new Date(1981,7,10),
    HiringDate = new Date(2023,2,10),
    Salary = 1080
};
Employee employee2 = new CommisionEmployee()
{
    Id = 2020,
    FirstName = "Anicacia",
    LastName = "Cuello",
    BirthDate = new Date(1958,12,15),
    HiringDate = new Date(2020,5,14),
    IsActive = true,
    CommisionPercentaje = 0.23f,
    Sales = 150
};

Console.WriteLine(employee1);
Console.WriteLine(employee2);