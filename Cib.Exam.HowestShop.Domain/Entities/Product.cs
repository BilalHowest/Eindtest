namespace Cib.Exam.HowestShop.Domain.Entities
{
    public class Product
    {
        public string Name { get; }
        public Category Category { get; }
        public decimal Price { get; }

        public Product(string name, Category category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Price}\t\t{Category}\t{Name}";
        }
    }
}
