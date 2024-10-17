using apitest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required] //data annotation
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Street {  get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        public ICollection<TstMdl> tstMdls { get; set; } = new List<TstMdl>();
    }
}
