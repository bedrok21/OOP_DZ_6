using OOP_DZ_6;
using System.Text.Json;
internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string path = @"C:\Workspace\JsonExample.json";
        string data = File.ReadAllText(path);

        var deserialisedData = JsonSerializer.Deserialize<List<Book>>(data);

        if (deserialisedData != null)
        {
            List<Book> books = deserialisedData;
            foreach (var book in books)
            {
                var publisher = book.PublishingHouse;
                Console.WriteLine($"{book.Title} - {publisher.Name} - {publisher.Adress}");
            }
        }
    }
}