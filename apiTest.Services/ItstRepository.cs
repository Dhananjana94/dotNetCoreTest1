using apitest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Services
{
    public interface ItstRepository
    {
        public List<TstMdl> AllTstModels();
    }
}
