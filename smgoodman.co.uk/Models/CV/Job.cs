using System;

namespace smgoodman.co.uk.Models.CV
{
    public class Job
    {
        public string Title { get; }
        public string Employer { get; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; }
        public string Description { get; }
        public string WebsiteUrl { get; }

        public Job(string title, string employer, DateTime startDate, DateTime? endDate, string websiteUrl, string description)
        {
            Title = title;
            Employer = employer;
            StartDate = startDate;
            EndDate = endDate;
            WebsiteUrl = websiteUrl;
            Description = description;
        }
    }
}