using Demo;

try 
{
    int.Parse("hey");
} catch(FormatException fe)
{
    System.Console.WriteLine("Heyyyyyyy");
    throw fe;
}
