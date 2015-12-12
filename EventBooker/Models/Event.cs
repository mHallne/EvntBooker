using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace EventBooker.Models
{
    public class Event
    {
        public int Id { get; set; } // Hide

        [Display(Name = "Namn på event")]
        public string Header { get; set; }

        [Display(Name = "Text")]
        public string Content { get; set; }

        [Display(Name = "Eventdatum")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime When { get; set; }

        //[Display(Name = "Eventtid")]
        //[DataType(DataType.Time)]
        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        //public DateTime Clock { get; set; }

        [Display(Name = "Plats")]
        public string Location { get; set; }

        [Display(Name = "Max antal deltagare")]
        public int MaxParticipants { get; set; }

        [Display(Name = "Inbjudan krävs")]
        public bool NeedInvitation { get; set; }

        [Display(Name = "Osa senast")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ResponeDeadline { get; set; }

        public string AddedBy { get; set; } // Hide
        public DateTime AddedDate { get; set; } // Hide
        public string UpdatedBy { get; set; } // Hide, kan vara null
        public DateTime UpdatedDate { get; set; } // hide, kan vara null
    }

    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}