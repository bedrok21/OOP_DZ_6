using System.Text.Json.Serialization;
namespace OOP_DZ_6
{
    internal class Book
    {
        //[JsonIgnore]
        public int PublishingHouseId { get; private set; }

        //[JsonPropertyName("Name")]
        public string Title { get; private set; }

        public Publisher PublishingHouse { get; private set; }

        public Book(int publishingHouseId, string title, Publisher publishingHouse)
        {
            PublishingHouseId = publishingHouseId;
            Title = title;
            PublishingHouse = publishingHouse;
        }
    }
}
