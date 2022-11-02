namespace OOP_DZ_6
{
    internal class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public Publisher(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
}
