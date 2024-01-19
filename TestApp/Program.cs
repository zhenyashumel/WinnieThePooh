using System.Data;

var table = new DataTable();
var result = table.Compute("3+3-(1+5) / 2 * 112 + 99.4344", string.Empty);
Console.WriteLine("don't fuck");
Console.Write(result);