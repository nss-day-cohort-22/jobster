using System;
using Xunit;
using Jobster;
using System.Collections.Generic;

namespace jobster.tests
{
    public class Jobster_Should
    {
        private Job _job;
        public Jobster_Should()
        {
            /*
                Properties of job
                    - Title
                    - Description
             */
            _job = new Job(
                1,
                "Junior Developer",
                "We need cheap labor"
            );
        }

        [Fact]
        public void GetAllJobs()
        {
            JobManager manager = new JobManager();
            manager.Add(_job);
            List<Job> allJobs = manager.GetAllJobs();

            Assert.Contains(_job, allJobs);
        }

        [Fact]
        public void GetSingleJob()
        {
            JobManager manager = new JobManager();
            manager.Add(_job);
            Job theJob = manager.GetSingleJob(1);


            Assert.Equal(theJob.Id, 1);
            Assert.Equal(theJob.Description, "We need cheap labor");
            Assert.Equal(theJob.Title, "Junior Developer");

        }


        [Fact]
        public void AddPropertiesToJobInstance()
        {
            // Assert that
            Assert.Equal(_job.Title, "Junior Developer");
            Assert.Equal(_job.Description, "We need cheap labor");

        }
    }
}
