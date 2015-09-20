using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smgoodman.co.uk.Models.CV
{
    public class Job
    {
        private string _title;
        private string _employer;
        private DateTime _startDate;
        private DateTime? _endDate;
        private string _description;
        private string _websiteUrl;

        public Job(string title, string employer, DateTime startDate, DateTime? endDate, string websiteUrl, string description)
        {
            _title = title;
            _employer = employer;
            _startDate = startDate;
            _endDate = endDate;
            _websiteUrl = websiteUrl;
            _description = description;
        }

        public string Title { get { return _title; } }
        public string Employer { get { return _employer; } }
        public DateTime StartDate { get { return _startDate; } }
        public DateTime? EndDate { get { return _endDate; } }
        public string Description { get { return _description; } }
        public string WebsiteUrl { get { return _websiteUrl; } }
    }
}