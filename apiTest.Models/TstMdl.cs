using apiTest.Models;
using System.ComponentModel.DataAnnotations;

namespace apitest.Models
{
    public class TstMdl
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get;set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public TstStatus Status { get; set; } // New,Inprogress,Completed
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
