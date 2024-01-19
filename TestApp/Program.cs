using System.Data;

Console.WriteLine("Welcome to me program");
var table = new DataTable();
var result = table.Compute("3+4-(1+5) + 99.43", string.Empty);
Console.WriteLine("Fuck");
Console.Write(result);
