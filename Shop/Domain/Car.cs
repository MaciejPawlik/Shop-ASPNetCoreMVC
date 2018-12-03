namespace Shop.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Distance { get; set; }
        public string Volume { get; set; }
        public string Fuel { get; set; }
        public string Power { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsCarOfWeek { get; set; }
    }
}
