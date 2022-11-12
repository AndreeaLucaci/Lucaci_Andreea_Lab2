namespace Lucaci_Andreea_Lab2.Models
{
    public class AuthorCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
