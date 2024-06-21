using apitest.Models;

namespace apitest.Service
{
    public class TstService
    {
        public List<TstMdl> AllTstModels()
        {
            var tsts = new List<TstMdl>();

            var tst1 = new TstMdl
            {
                Id = 1,
                Title = "Test model 1",
                Description = "testing model 1",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TstStatus.New
            };
            tsts.Add(tst1);

            var tst2 = new TstMdl
            {
                Id = 2,
                Title = "Test model 2",
                Description = "testing model 2",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TstStatus.New
            };
            tsts.Add(tst2);

            var tst3 = new TstMdl
            {
                Id = 3,
                Title = "Test model 3",
                Description = "testing model 3",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TstStatus.Completed
            };
            tsts.Add(tst3);

            return tsts;
        }
    }
}
