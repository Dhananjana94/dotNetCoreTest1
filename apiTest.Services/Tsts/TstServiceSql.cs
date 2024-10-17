using apitest.Models;
using apiTest.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Services.Tsts
{
    public class TstServiceSql : ItstRepository
    {
        private TestDbContext _context = new TestDbContext();
        public List<TstMdl> AllTstModels(int authorID)
        {
            return _context.TstMdlTble.Where(t=> t.AuthorId == authorID).ToList(); // return test data based on the author ID
        }

        public TstMdl GetTstById(int authorID, int id)
        {
            return _context.TstMdlTble.FirstOrDefault(t=> t.Id == id && t.AuthorId == authorID);
        }
    }
}
