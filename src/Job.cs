namespace Jobster
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; } = 1;
        public int ResumeId { get; set; }
        public int CompanyId { get; set; }


        public Job ()
        {
            this.Id = 1;
            this.Title = "test";
            this.Description = "test";
            this.CompanyId = 1;
            this.ResumeId = 1;
        }

        // Constructor for Job accepting title, and description parameters
        public Job (int id, string title, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.CompanyId = 1;
            this.ResumeId = 1;
        }
    }
}