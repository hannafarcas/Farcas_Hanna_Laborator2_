using Farcas_Hanna_Laborator2.Models;
namespace Farcas_Hanna_Laborator2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
