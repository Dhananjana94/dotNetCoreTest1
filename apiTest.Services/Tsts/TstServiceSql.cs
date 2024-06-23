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
        public List<TstMdl> AllTstModels()
        {
            return _context.TstMdlTble.ToList();
        }
    }
}
