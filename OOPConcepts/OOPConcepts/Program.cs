// See https://aka.ms/new-console-template for more information

using OOPConcepts;

try
{ 
	Console.WriteLine(new Date(1874,11,14));
	Console.WriteLine(new Date(2023,1,31));

}
catch (Exception error)
{
	Console.WriteLine($"Error: {error.Message}");
}
