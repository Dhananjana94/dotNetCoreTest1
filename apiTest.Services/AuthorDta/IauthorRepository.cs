using apiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Services.AuthorDta
{
    public interface IauthorRepository
    {
        public List<Author> GetAllAuthors();

        public Author GetAuthorById(int Id);
    }
}
