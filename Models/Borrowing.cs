using System.ComponentModel.DataAnnotations;

namespace Farcas_Hanna_Laborator2.Models
{
    public class Borrowing
    {
        public int Id { get; set; }
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        public int? BookID { get; set; }
        public Book? Book { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
