using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetConf.Web
{
    public class Locale
    {
        public Conf Conf { get; set; }
        public Calltoaction CallToAction { get; set; }
        public Forkbutton ForkButton { get; set; }
        public Site Site { get; set; }
        public string[] Sections { get; set; }
        public Labels Labels { get; set; }
        public Schedule[] Schedule { get; set; }
        public Sponsor[] Sponsors { get; set; }
        public Partner[] Partners { get; set; }
        public Community[] Communities { get; set; }
    }

    public class Conf
    {
        public string Name { get; set; }
        public string SummaryTitle { get; set; }
        public string[] Description { get; set; }
        public string Date { get; set; }
        public DateTime Coundown { get; set; }
        public string Venue { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    public class Calltoaction
    {
        public string Text { get; set; }
        public string Link { get; set; }
    }

    public class Forkbutton
    {
        public string Repository { get; set; }
    }

    public class Site
    {
        public string Url { get; set; }
    }

    public class Labels
    {
        public string About { get; set; }
        public string Location { get; set; }
        public string Speakers { get; set; }
        public string Schedule { get; set; }
        public string Sponsors { get; set; }
        public string Partners { get; set; }
        public string Contact { get; set; }
        public string OurSponsors { get; set; }
        public string OurPartners { get; set; }
        public string Communities { get; set; }
    }

    public class Schedule
    {
        public string Time { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }
        public string Company { get; set; }
        public Link Link { get; set; }
        public Presentation Presentation { get; set; }
    }

    public class Link
    {
        public string Href { get; set; }
        public string Text { get; set; }
    }

    public class Presentation
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
    }

    public class Sponsor
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public int Width { get; set; } = 200;
    }

    public class Partner
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public int Width { get; set; } = 200;
    }

    public class Community
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public int Width { get; set; } = 200;
    }
}