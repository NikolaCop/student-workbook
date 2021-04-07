using System;
using System.ComponentModel.DataAnnotations;

namespace GregslistC_.Models
{
    public class Job
    {
        internal int id;
        internal string jobId;

        public Job(string title, string description, int rate)
        {
            Title = title;
            Description = description;
            Rate = rate;
        }

        public Job()
        {

        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }
}