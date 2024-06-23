using apiTest.DataAccess;
using apiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Services.AuthorDta
{
    public class AuthorServiceSql : IauthorRepository
    {
        private TestDbContext _dbContext = new TestDbContext();
        public List<Author> GetAllAuthors()
        {
            return _dbContext.Authors.ToList();
        }

        public Author GetAuthorById(int Id)
        {
            return _dbContext.Authors.Find(Id);
        }
    }
}
