using apitest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Services.Tsts
{
    public interface ItstRepository
    {
        public List<TstMdl> AllTstModels();

        public TstMdl GetTstById(int id);
    }
}
