using BuilderPattern.Method1;
using BuilderPattern.Method2;
using System.Text;






//var sb = new StringBuilder();

//sb.Append("Mustafa");
//sb.Append("Cenan");

//var fullname = sb.ToString();

var baseURL = "https://localhost:8080";

var eb = new EndpointBuilder(baseURL);

eb
    .Append("api")
    .Append("v1")
    .Append("user")
    .AppendParam("id", "5")
    .AppendParam("username", "5");
 

var a = eb.Build().ToString();
//Console.WriteLine(a);

var empBuilder = new EmployeeBuilderM1();

var employe = empBuilder
    .SetFullName("Mustafa Cenan")
    .SetUserName("54cenan54")
    .SetEmailAddress("user@gmail.com")
    .BuildEmployee();

System.Console.WriteLine(employe.FirstName);
employe.ToString();



IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();
empBuilder.SetEmailAddress("mustafacenan@gmail.com");