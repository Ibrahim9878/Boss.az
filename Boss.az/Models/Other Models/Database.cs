namespace Boss.az.Models.Other_Models;

using System.Text.Json;
using Boss.az.Models.Humans;
public static class Database
{
    public static List<Worker> workers = new();
    public static List<Employer> employers = new();
    public static List<Vacancie> vacancies = new();

    public static void ShowWorkers()
    {
        foreach (var item in workers)
        {
            Console.WriteLine(item);
        }
    }
    public static void ShowEmployers()
    {
        foreach (var item in employers)
        {
            Console.WriteLine(item);
        }
    }
    public static void ShowVacncies()
    {
        foreach (var item in vacancies)
        {
            Console.WriteLine(item);
        }
    }

    public static void WriteWorkersToJson()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(workers, options);

        File.WriteAllText("workers.json", jsonString);

        Console.WriteLine("Workers have been successfully written to workers.json.");
    }
    public static void WriteEmployersToJson()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(workers, options);

        File.WriteAllText("employers.json", jsonString);

        Console.WriteLine("Employers have been successfully written to employers.json.");
    }
    
}
