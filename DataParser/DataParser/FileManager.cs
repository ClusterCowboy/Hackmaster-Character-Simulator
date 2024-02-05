using System.Text.Json;

namespace DataParser
{
    public class FileManager<T>
    {
        private readonly string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void WriteToFile(T data)
        {
            string jsonData = JsonSerializer.Serialize(data);

            // Write to file
            File.WriteAllText(filePath, jsonData);
        }

        public T ReadFromFile()
        {
            // Read from file
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonData);
            }

            return default(T);
        }
    }

}
