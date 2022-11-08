namespace Oana_Oprea_lab2.Models.LibraryViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<Customer> Customers { get; set; }

    }
}
