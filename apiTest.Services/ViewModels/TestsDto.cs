using apitest.Models;
using apiTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Services.ViewModels
{
    public class TestsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Status { get; set; } // New,Inprogress,Completed
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
