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
        public Dictionary<string, string> Labels { get; set; }
        public Schedule[] Schedule { get; set; }
        public Sponsor[] Sponsors { get; set; }
        public Partner[] Partners { get; set; }
        public VenueSupport[] VenueSupports { get; set; }
        public BooksSponsor[] BooksSponsors { get; set; }
        public Community[] Communities { get; set; }
        public Organizer[] Organizers { get; set; }
        public Speaker[] Speakers { get; set; }
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

        public string Level { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public int Width { get; set; } = 200;
        public string Introduction { get; set; }
    }

    public class Partner
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public int Width { get; set; } = 200;
    }

    public class VenueSupport
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public int Width { get; set; } = 200;
    }

    public class BooksSponsor
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

    public class Organizer
    {
        public string Group { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }

    public class Speaker
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Image { get; set; }
        public string DifficultyLevel { get; set; }
        public string[] Introduction { get; set; }
        public string Topic { get; set; }
        public string Time { get; set; }
        public string[] Description { get; set; }
    }
}