namespace WebApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
