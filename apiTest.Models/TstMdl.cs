namespace apitest.Models
{
    public class TstMdl
    {
        public int Id { get; set; }
        public string Title { get;set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public TstStatus Status { get; set; } // New,Inprogress,Completed
    }
}
