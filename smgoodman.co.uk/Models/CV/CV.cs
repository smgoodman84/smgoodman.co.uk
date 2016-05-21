using System;
using System.Collections.Generic;

namespace smgoodman.co.uk.Models.CV
{
    public static class CV
    {
        public static string PersonalStatement = @"I am a self motivated software developer with an unflagging energy to do things better.

I am passionate about delivering software with a real business benefit. I aim to understand what the business needs and focus on creating the best solution to the problem, never forgetting to consider non-technical options. I am always mindful of the direction of the business and am keen to be involved in helping the business achieve it’s goals.

When it comes to software development I like to keep things simple. I always consider the system’s architecture and aim to make it more elegant, robust and understandable. I find the SOLID principles to be vital in achieving this.

When working on existing code, I follow the boy scout principle and leave the code better than when I came to it. I find automated testing to be invaluable and get a sense of satisfaction from producing reliable code.

In a crisis I remain calm under pressure and methodically work through the problem at hand. I avoid knee-jerk reactions and get the system working again, then attempt to understand the root cause of the issue.";

        public static List<Skill> Skills = new List<Skill>
        {
            new Skill("C#"),
            new Skill("SQL"),
            new Skill("MVC"),
            new Skill("PHP"),
            new Skill("Java"),
            new Skill("C"),
            new Skill("HTML"),
            new Skill("CSS"),
            new Skill("JavaScript"),
            new Skill("SOLID Principles"),
            new Skill("Test Driven Development"),
            new Skill("SOA/Microservices"),
            new Skill("RabbitMQ"),
            new Skill("Continuous Integration"),
        };

        public static List<Hobby> Hobbies = new List<Hobby>
        {
            new Hobby("Photography"),
            new Hobby("Table Tennis"),
            new Hobby("Reading"),
            new Hobby("Running"),
            new Hobby("Travel"),
            new Hobby("Rock Climbing"),
        };

        public static List<Job> Jobs = new List<Job>
        {
            new Job(
                "Senior Software Developer",
                "Amigo Loans",
                new DateTime(2012,10,1),
                null,
                "www.amigoloans.co.uk",
                @"My experience at Amigo has helped me appreciate the difference between a well architected system and a poorly architected system. This has mainly been a result of an ongoing project to rebuild a monolithic system using an SOA/Microservices approach. The SOLID principles, design patterns and continuous integration have been a big part of the rebuild effort.

A large part of my time has been spent developing “The People System”; a system designed to store basic personal details of Amigo customers. The aim of the system is for it to recognise when a customer has made more than one application and to link the applications together. I developed logic to identify duplicate applications and then created an implementation that matched new applications to existing applications in under a second.

I am the engineering expert for all systems involved in communicating with Amigo’s business partners’. This involves working with engineers from other companies to make sure that our systems integrate seamlessly, allowing partners to introduce customers to Amigo and allowing them to read reporting data from our systems. As 40% of Amigo’s customers are referred by a partner, these systems are a vital part of the business.

I have also developed a number of small applications that provide more effective management and monitoring of the main systems as part of an effort to make the system more reliable. In an attempt to share the engineering teams’ knowledge and improve communication I organised a weekend away where we discussed the high level architecture and direction of our systems."
                ),
            new Job(
                "Lead Developer",
                "Ratio Network",
                new DateTime(2010,1,1),
                new DateTime(2012,10,1),
                "www.rationetwork.co.uk",
                @"When I joined the company I worked in the Loanfinder division (a loan comparison website). I quickly earned the nickname ""SQL Simon"" from my colleagues when they recognised my passion for SQL and databases. My main focus was on improving the back end systems that supported the companies’ website. This included developing a new payment system that supports direct debit and credit card payments.

After my first year, I was chosen to work on the division’s flagship project to whitelabel the Loanfinder website. This system made Loanfinder’s loan recommendation system available to anyone wishing to use it. The business evolved to make this system it’s core product and I spent a large amount of time building new features and adding new products to it that ultimately enabled Ratio to become it’s own business.

As lead developer it was my responsibility to make sure our systems stayed up 24/7. To help achieve this I designed and built two systems - Loudspeaker and Chirp; systems that provided error monitoring and system monitoring (in the style of twitter) respectively. The business valued a fast development process and these systems allowed us to react quickly when that had compromised the stability of the system."
                ),
            new Job(
                "Senior Software & IT Support Consultant",
                "FITSystems",
                new DateTime(2009,5,1),
                new DateTime(2009,12,1),
                "www.fitsystems.co.uk",
                @"Having taken a few months off work to travel the world I came back to the company I helped found. In the time I had been gone, the company had managed to grow to the point where it was ready to take on an extra person. I returned with three years commercial experience looking to grow the software side of the business.

My main project was to build a ticket booking system for a small music festival (The Rockabilly Rave). The system allowed customers to make a booking, took card payments and allowed staff to manage the attendance list."
                ),
            new Job(
                "Senior Design Engineer",
                "Telsis",
                new DateTime(2005,10,1),
                new DateTime(2009,1,1),
                "www.telsis.com",
                @"In my first job working alongside other professional engineers I learned how to build software as part of a team and began to understand how development processes guide how software is built and ensure the required standards are met. I became the most senior engineer in the management software department, helping to mentor those with less experience."
                ),
            new Job(
                "Director",
                "FITSystems",
                new DateTime(2005,6,1),
                new DateTime(2005,12,1),
                "www.fitsystems.co.uk",
                @"When I left university, I founded FITSystems with two friends from school. Our business plan was to offer IT support and software development services to businesses that were too small to have their own in-house teams. This experience taught me a lot about what is required to start a business and about some of the difficulties involved in making a business work."
                ),
        };
    }
}