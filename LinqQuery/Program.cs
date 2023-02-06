/*
 * What is Linq All Operator in C#?
The Linq All Operator in C# is used to check whether all the elements of a data source
satisfy a given condition or not. If all the elements satisfy the condition,
then it returns true else return false.
There is no overloaded version is available for the All method.
The definition is given below.
 */

using LinqQuery;
using LinqQuery.GroupByDemo;
/*
 * All
 * Any
 * Contain
 * GroupBy
 * GroupBy By Multiple Keys in Linq
 */
/*

int[] IntArray = { 11, 22, 33, 44, 55 };
var Result = IntArray.All(x => x > 10);
Console.WriteLine("Is All Numbers are greater than 10 : " + Result);


string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
var Result1 = stringArray.All(name => name == "Sara");
Console.WriteLine("Is All Names are greater than 5 Characters : " + Result1);

string[] stringArray1 = { "James", "Sachin", "Sourav", "Pam", "Sara" };
var Result2 = stringArray1.Any(name => name=="Sara");
Console.WriteLine("Is All Names are greater than 5 Characters : " + Result2);


var MSResult = Student.GetAllStudnets()
                   .Where(std => std.Subjects.All(x => x.Marks > 80)).ToList();

//Using Query Syntax
var QSResult = (from std in Student.GetAllStudnets()
                where std.Subjects.All(x => x.Marks > 80)
                select std).ToList();
foreach (var item in QSResult)
{
    Console.WriteLine(item.Name + " " + item.TotalMarks);
}

foreach (var item in MSResult)
{
    Console.WriteLine(item.Name + " " + item.TotalMarks);
}
*/
/*
int[] IntArray = { 11, 22, 33, 44, 33, 55 };
//Using Method Syntax
var IsExistsMS = IntArray.Contains(33);
//Using Query Syntax
var IsExistsQS = (from num in IntArray
                  select num).Contains(33);
Console.WriteLine(IsExistsMS);*/
//Using Method Syntax


/*
var GroupByMS = Student.GetStudents().GroupBy(s => s.Barnch);
//Using Query Syntax
IEnumerable<IGrouping<string, Student>> GroupByQS = (from std in Student.GetStudents()
                                                     group std by std.Barnch);
//It will iterate through each groups
foreach (var group in GroupByMS)
{
    Console.WriteLine(group.Key + " : " + group.Count());
    //Iterate through each student of a group
    foreach (var student in group)
    {
        Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
    }
}

var GroupByMS1 = Student.GetStudents().GroupBy(s => s.Gender)
                         //First sorting the data based on key in Descending Order
                         .OrderByDescending(c => c.Key)
                         .Select(std => new
                         {
                             Key = std.Key,
                             //Sorting the data based on name in descending order
                             Students = std.OrderBy(x => x.Name)
                         });
//Using Query Syntax
var GroupByQS1 = from std in Student.GetStudents()
                group std by std.Gender into stdGroup
                orderby stdGroup.Key descending
                select new
                {
                    Key = stdGroup.Key,
                    Students = stdGroup.OrderBy(x => x.Name)
                };
//It will iterate through each groups
foreach (var group in GroupByQS1)
{
    Console.WriteLine(group.Key + " : " + group.Students.Count());
    //Iterate through each student of a group
    foreach (var student in group.Students)
    {
        Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" + student.Barnch);
    }
}
*/
/*
var GroupByMultipleKeysMS = Student.GetStudents()
                                      .GroupBy(x => new { x.Barnch, x.Gender })
                                      .OrderByDescending(g => g.Key.Barnch).ThenBy(g => g.Key.Gender)
                                      .Select(g => new
                                      {
                                          Branch = g.Key.Barnch,
                                          Gender = g.Key.Gender,
                                          Students = g.OrderBy(x => x.Name)
                                      });
//Using Query Syntax
var GroupByMultipleKeysQS = from student in Student.GetStudents()
                            group student by new
                            {
                                student.Barnch,
                                student.Gender
                            } into stdGroup
                            orderby stdGroup.Key.Barnch descending,
                                    stdGroup.Key.Gender ascending
                            select new
                            {
                                Branch = stdGroup.Key.Barnch,
                                Gender = stdGroup.Key.Gender,
                                Students = stdGroup.OrderBy(x => x.Name)
                            };
//It will iterate through each group
foreach (var group in GroupByMultipleKeysQS)
{
    Console.WriteLine($"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
    //It will iterate through each item of a group
    foreach (var student in group.Students)
    {
        Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
    }
    Console.WriteLine();
}
*/
/*
 * In this article, I am going to discuss the difference between Deferred Execution vs 
 * Immediate Execution in LINQ with some examples. Please read our previous article
 * where we discussed the LINQ Zip Method with an example. The LINQ queries are executed 
 * in two different ways as follows.

Deferred execution
Immediate execution
Based on the above two types of execution, the LINQ operators are divided into 2 categories. They are as follows:

Deferred or Lazy Operators:  These query operators are used for deferred execution.
For example – select, SelectMany, where, Take, Skip, etc. are belongs to Deferred or
Lazy Operators category.
Immediate or Greedy Operators: These query operators are used for immediate execution.
For Example – count, average, min, max, First, Last, ToArray, ToList, etc. 
are belongs to the Immediate or Greedy Operators category.
LINQ Deferred Execution:

The Linq ToLookup Method in C# exactly does the same thing as the GroupBy Operator 
does in Linq. The only difference between these two methods is the GroupBy method
uses deferred execution whereas the execution of the ToLookup method is immediate.
Please read the following article to understand what is Deferred and Immediate Execution
in Linq queries.
 */
/*

//Using Method Syntax
var GroupByMS = Student.GetStudents().ToLookup(s => s.Barnch);
//Using Query Syntax
var GroupByQS = (from std in Student.GetStudents()
                 select std).ToLookup(x => x.Barnch);
//It will iterate through each group
foreach (var group in GroupByMS)
{
    Console.WriteLine(group.Key + " : " + group.Count());
    //Iterate through each student of a group
    foreach (var student in group)
    {
        Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
    }
}
*/
var GroupByMS = Student.GetStudents().ToLookup(s => s.Gender)
                           .OrderByDescending(c => c.Key)
                           .Select(std => new
                           {
                               Key = std.Key,
                               Students = std.OrderBy(x => x.Name)
                           });

foreach (var group in GroupByMS)
{
    Console.WriteLine(group.Key + " : " + group.Students.Count());
    foreach (var student in group.Students)
    {
        Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" + student.Barnch);
    }
}

//https://dotnettutorials.net/lesson/linq-joins-in-csharp/