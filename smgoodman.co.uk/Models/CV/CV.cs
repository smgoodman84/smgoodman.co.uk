using System;
using System.Collections.Generic;

namespace smgoodman.co.uk.Models.CV
{
    public static class CV
    {
        public static string PersonalStatement = @"I love working with others to build great software.

I take pride in being able to design and build software that solves real world problems. I enjoy learning about a need that someone has, and then working with them to understand how a software system might help them. When building software, I like to deliver value quickly and then iterate; adding, removing and modifying features until the best solution is delivered. I love the challenge of balancing all sorts of requirement, from functional and user experience requirements, to performance, security and quality requirements; always keeping costs and timescales in mind.

I believe that effective teamwork and communication are vital when it comes to delivering software. As a result, I have made them a focus throughout my career. Getting everyone pulling in the same direction can be challenging, but is well worth the effort in order to be able to deliver the best solution.

Co-founding an IT Support and Software Development company when I first left university gave me first hand experience of the challenges of running a business. It also gave me an appreciation of all parts of a business, from marketing, design and ux to analytics, analysis and business development. This stops me from focusing solely on technical problems and allows me to focus on wider business needs instead.

I enjoy keeping up to date with new approaches to solving problems, I primarily do this by reading plenty of books and blogs. I put these ideas into practice by working on toy projects and code katas at home and when appropriate bringing new ideas to the workplace.";

        public static List<Skill> Skills = new List<Skill>
        {
            new Skill("C#"),
            new Skill("SQL"),
            new Skill("JavaScript"),
            new Skill("HTML"),
            new Skill("CSS"),
            new Skill("SOLID Principles"),
            new Skill("Test Driven Development"),
            new Skill("Agile"),
            new Skill("Continuous Integration"),
            new Skill("DevOps"),
            new Skill("Micorservices"),
            new Skill("Event Sourcing"),
            new Skill("MVC"),
        };

        public static List<Hobby> Hobbies = new List<Hobby>
        {
            new Hobby("Photography"),
            new Hobby("Reading"),
            new Hobby("Travel"),
            new Hobby("Foosball"),
            new Hobby("Table Tennis"),
            new Hobby("Running"),
            new Hobby("Rock Climbing"),
        };

        public static List<Job> Jobs = new List<Job>
        {
            new Job(
                "Software Developer",
                "Redgate Software",
                new DateTime(2015,05,1),
                null,
                "www.red-gate.com",
                @"When I first began at Redgate I had the chance to work closely with Oracle, something that has given me a broader perspective on database technologies. I have also gained a greater appreciation of the role that UX and design play in software when I was part of a team who were updating a UI as part of a UI consistency project.

At Redgate I have had the chance to experience some of the many ways in which technical knowledge can be shared, including pair programming, discussion groups, lightning talks and blog posts. I also had the opportunity to coach a test engineer in software development, something I particularly enjoyed."
                ),
            new Job(
                "Senior Software Developer",
                "Amigo Loans",
                new DateTime(2012,10,1),
                new DateTime(2015,05,1),
                "www.amigoloans.co.uk",
                @"During my time at Amigo, the business was constantly changing and adapting to market conditions. This meant we were constantly updating and improving the business systems. 

We systematically worked our way through every part of the business, refining the business process and supporting software so the business could function more efficiently. We used a microservices approach, breaking down the business functionality into a large number of services, each with clear and well defined responsibilities. I particularly enjoyed architectural discussions around how different services should interact and the implications of different approaches.

I was responsible for supporting the external APIs made available to business partners that integrated with our systems. This required me to be able to effectively communicate with people from outside the business about technical details and how it related to business objectives.

I spent a lot of time working on the People system, this system required me to build a database that allowed all new loan applications to be fuzzy matched instantly to tens of millions of existing customer records.

I would help other developers troubleshoot performance problems, particularly optimising database queries and tuning database workloads; work that I found very satisfying."
                ),
            new Job(
                "Lead Developer",
                "Ratio Network",
                new DateTime(2010,1,1),
                new DateTime(2012,10,1),
                "www.rationetwork.co.uk",
                @"As the lead developer at Ratio I was responsible for ensuring that the development standards met the needs of the business. This included making sure that all software had an appropriate architecture, as well as ensuring that code and quality standards were met. 

I was also responsible for ensuring that all our websites and systems never had significant periods of downtime. I would discuss software designs with developers to ensure that the requirements had been met and that the software would be simple to maintain. I would perform code reviews for developers and pair program with them when they were new to a codebase.

I was the main technical point of contact for our external APIs and would often discuss what was possible technically when it comes to integrating with business partners. I also discussed how these integrations should be implemented with members of their technical team.

As a side project, I developed a number of systems that provide monitoring and alerting in order to improve performance and uptime metrics. This included an alerting wallboard that would display errors from every software system across the business. It would also send email or sms alerts if the error was severe enough. I also created a news feed style interface for the system. It provided visibility of important operations being performed by the system allowing us to see when something was not quite right. I also developed a number of reporting interfaces for displaying tables, charts and graphs of important business and technical metrics. These systems allowed us to react quickly when there was a problem so it could be resolved sooner."
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