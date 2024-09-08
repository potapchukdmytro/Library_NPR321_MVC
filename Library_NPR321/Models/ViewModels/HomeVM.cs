namespace Library_NPR321.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Book> Books { get; set; } = new List<Book>();
        public IEnumerable<Author> Authors { get; set; } = new List<Author>();
    }
}
