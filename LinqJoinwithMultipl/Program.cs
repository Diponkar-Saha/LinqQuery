using LinqJoinwithMultipl;

var JoinMultipleDSUsingQS = (//Data Source1
                                       from emp in Employee.GetAllEmployees()
                                           //Joining with Address Data Source (Data Source2)
                                       join adrs in Address.GetAllAddresses()
                                       on emp.AddressId equals adrs.ID
                                       //Joining with Department Data Source (Data Source3)
                                       join dept in Department.GetAllDepartments()
                                       on emp.DepartmentId equals dept.ID
                                       //Projecting the result set
                                       select new
                                       {
                                           ID = emp.ID,
                                           EmployeeName = emp.Name,
                                           DepartmentName = dept.Name,
                                           AddressLine = adrs.AddressLine
                                       }).ToList();
foreach (var employee in JoinMultipleDSUsingQS)
{
    Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
}