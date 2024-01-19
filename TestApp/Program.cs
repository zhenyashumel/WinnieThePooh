using System.Data;

var table = new DataTable();
var result = table.Compute("3+3-(1+5) + 99.43", string.Empty);
Console.Write(result);