using InnerJoinLinq;

/*
var JoinUsingMS = Employee.GetAllEmployees() //Outer Data Source
                         .Join(
                         Address.GetAllAddresses(),  //Inner Data Source
                         employee => employee.AddressId, //Inner Key Selector
                         address => address.ID, //Outer Key selector
                         (employee, address) => new //Projecting the data into a result set
                         {
                             EmployeeName = employee.Name,
                             AddressLine = address.AddressLine
                         }).ToList();
foreach (var employee in JoinUsingMS)
{
    Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
}
*/
var JoinUsingQS = (from emp in Employee.GetAllEmployees()
                   join address in Address.GetAllAddresses()
                   on emp.AddressId equals address.ID
                   select new
                   {
                       EmployeeName = emp.Name,
                       AddressLine = address.AddressLine
                   }).ToList();
foreach (var employee in JoinUsingQS)
{
    Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
}
