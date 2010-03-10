#pragma warning disable 649    // disable compiler warnings about unassigned fields

namespace TERSApplication.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.Web.DomainServices;
    using System.Web.Ria;
    using System.Web.Ria.Services;


    // The MetadataTypeAttribute identifies EventTypeMetadata as the class
    // that carries additional metadata for the EventType class.
    [MetadataTypeAttribute(typeof(EventType.EventTypeMetadata))]
    public partial class EventType
    {

        // This class allows you to attach custom attributes to properties
        // of the EventType class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class EventTypeMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private EventTypeMetadata()
            {
            }

            public Nullable<DateTime> CreateDate;

            public string CreatedBy;

            public int EventTypeID;

            public string EventTypeName;

            public Nullable<DateTime> ModifyDate;

            public EntityCollection<Occurrence> Occurrences;
        }
    }

    // The MetadataTypeAttribute identifies OccurrenceMetadata as the class
    // that carries additional metadata for the Occurrence class.
    [MetadataTypeAttribute(typeof(Occurrence.OccurrenceMetadata))]
    public partial class Occurrence
    {

        // This class allows you to attach custom attributes to properties
        // of the Occurrence class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class OccurrenceMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private OccurrenceMetadata()
            {
            }

            public Nullable<int> CatalogID;

            public Nullable<int> ConversionInstructorID;

            public Nullable<int> ConversionScheduleID;

            public Nullable<DateTime> CreateDate;

            public int CreatedByEmpID;

            public Nullable<int> DaysBeforeSendingReminder;

            public string Description;

            public EntityCollection<Employeesignup> Employeesignups;

            public int EventID;

            public EventType EventType;

            public int EventTypeID;

            public Nullable<bool> IsAllDay;

            public string LocationName;

            public Nullable<int> MaxAttend;

            public Nullable<DateTime> ModifyDate;

            public int OccurrenceID;

            public string OccurrenceName;

            public EntityCollection<OccurrenceReminderEmailAttachment> OccurrenceReminderEmailAttachments;

            public Nullable<decimal> OrgNo;

            public string Recurrence;

            public Region Region;

            public Nullable<int> RegionID;

            public string ReminderBody;

            public string ReminderSubject;

            public DateTime ScheduleFrom;

            public Nullable<DateTime> ScheduleTo;

            public Nullable<bool> ShowVideoConf;

            public TrainingEvent TrainingEvent;
        }
    }

    // The MetadataTypeAttribute identifies ProgramMetadata as the class
    // that carries additional metadata for the Program class.
    [MetadataTypeAttribute(typeof(Program.ProgramMetadata))]
    public partial class Program
    {

        // This class allows you to attach custom attributes to properties
        // of the Program class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class ProgramMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProgramMetadata()
            {
            }

            public EntityCollection<Catalog> Catalogs;

            public string CCEmail;

            public EntityCollection<Contact> Contacts;

            public Nullable<DateTime> CreateDate;

            public int CreatedByID;

            public string Division;

            public string ModifyBy;

            public Nullable<DateTime> ModifyDate;

            public string OfficeCode;

            public string ProgramDescription;

            public int ProgramID;

            public string ProgramName;

            public EntityCollection<TrainingEvent> TrainingEvents;
        }
    }

    // The MetadataTypeAttribute identifies RegionMetadata as the class
    // that carries additional metadata for the Region class.
    [MetadataTypeAttribute(typeof(Region.RegionMetadata))]
    public partial class Region
    {

        // This class allows you to attach custom attributes to properties
        // of the Region class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class RegionMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RegionMetadata()
            {
            }

            public EntityCollection<Occurrence> Occurrences;

            public string RegionFullName;

            public int RegionID;

            public string RegionName;

            public int TimeZoneID;

            public string TimeZoneName;
        }
    }

    // The MetadataTypeAttribute identifies TrainingEventMetadata as the class
    // that carries additional metadata for the TrainingEvent class.
    [MetadataTypeAttribute(typeof(TrainingEvent.TrainingEventMetadata))]
    public partial class TrainingEvent
    {

        // This class allows you to attach custom attributes to properties
        // of the TrainingEvent class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class TrainingEventMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private TrainingEventMetadata()
            {
            }

            public Nullable<DateTime> CreateDate;

            public int CreatedByID;

            public Nullable<int> DaysBeforeSendingInvite;

            public Nullable<bool> EmailSent;

            public int EventID;

            public string EventName;

            public EntityCollection<InvitedEmail> InvitedEmails;

            public EntityCollection<InvitedEmployee> InvitedEmployees;

            public EntityCollection<InviteEmailAttachment> InviteEmailAttachments;

            public string InviteEmailBody;

            public string InviteEmailSubject;

            public bool IsActive;

            public bool IsPublic;

            public string ModifyBy;

            public Nullable<DateTime> ModifyDate;

            public EntityCollection<Occurrence> Occurrences;

            public Nullable<decimal> OrgNo;

            public Program Program;

            public int ProgramID;
        }
    }
}

#pragma warning restore 649    // re-enable compiler warnings about unassigned fields
