using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        

        string jsonString = JsonSerializer.Serialize(s);
        Console.WriteLine(jsonString);  

    }
}