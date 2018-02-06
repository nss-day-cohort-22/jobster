using System.Collections.Generic;
using System.Linq;

namespace Jobster
{
    public class JobManager
    {
        private List<Job> _jobTable = new List<Job>();

        public void Add(Job steve)
        {
            _jobTable.Add(steve);
        }

        public List<Job> GetAllJobs ()
        {
            return _jobTable;
        }

        public Job GetSingleJob(int id)
        {
            return _jobTable.Where(j => j.Id == id).Single();
        }
    }
}