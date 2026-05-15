using System.Text.Json;

namespace CafeSystem.Domain.Services;

public class JsonService
{
    public void Save<T>(T data, string fileName)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(data, options);

        File.WriteAllText(fileName, json);
    }

    public T? Load<T>(string fileName)
    {
        if (!File.Exists(fileName))
        {
            return default;
        }

        string json = File.ReadAllText(fileName);

        return JsonSerializer.Deserialize<T>(json);
    }
}