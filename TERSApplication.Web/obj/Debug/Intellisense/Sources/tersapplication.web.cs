//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TERSApplication.Web {
    
    
    [global::System.Web.Ria.EnableClientAccessAttribute()]
    public class AuthenticationService : global::System.Web.Ria.ApplicationServices.AuthenticationBase<global::TERSApplication.Web.User> {
        
        public AuthenticationService() {
        }
    }
    
    public class EventReadOnly {
        
        public EventReadOnly() {
        }
        
        [global::System.ComponentModel.DataAnnotations.KeyAttribute()]
        public int EventID {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        public string EventName {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        public string Status {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        public string CreatedBy {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
    }
    
    [global::System.ComponentModel.DataAnnotations.MetadataTypeAttribute(typeof(global::TERSApplication.Web.EventType.EventTypeMetadata))]
    public partial class EventType : global::System.Data.Objects.DataClasses.EntityObject {
        
        public EventType() {
        }
        
        internal sealed class EventTypeMetadata {
            
            public global::System.Nullable<global::System.DateTime> CreateDate;
            
            public string CreatedBy;
            
            public int EventTypeID;
            
            public string EventTypeName;
            
            public global::System.Nullable<global::System.DateTime> ModifyDate;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.Occurrence> Occurrences;
        }
    }
    
    [global::System.ComponentModel.DataAnnotations.MetadataTypeAttribute(typeof(global::TERSApplication.Web.Occurrence.OccurrenceMetadata))]
    public partial class Occurrence : global::System.Data.Objects.DataClasses.EntityObject {
        
        public Occurrence() {
        }
        
        internal sealed class OccurrenceMetadata {
            
            public global::System.Nullable<int> CatalogID;
            
            public global::System.Nullable<int> ConversionInstructorID;
            
            public global::System.Nullable<int> ConversionScheduleID;
            
            public global::System.Nullable<global::System.DateTime> CreateDate;
            
            public int CreatedByEmpID;
            
            public global::System.Nullable<int> DaysBeforeSendingReminder;
            
            public string Description;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.Employeesignup> Employeesignups;
            
            public int EventID;
            
            public global::TERSApplication.Web.EventType EventType;
            
            public int EventTypeID;
            
            public global::System.Nullable<bool> IsAllDay;
            
            public string LocationName;
            
            public global::System.Nullable<int> MaxAttend;
            
            public global::System.Nullable<global::System.DateTime> ModifyDate;
            
            public int OccurrenceID;
            
            public string OccurrenceName;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.OccurrenceReminderEmailAttachment> OccurrenceReminderEmailAttachments;
            
            public global::System.Nullable<decimal> OrgNo;
            
            public string Recurrence;
            
            public global::TERSApplication.Web.Region Region;
            
            public global::System.Nullable<int> RegionID;
            
            public string ReminderBody;
            
            public string ReminderSubject;
            
            public global::System.DateTime ScheduleFrom;
            
            public global::System.Nullable<global::System.DateTime> ScheduleTo;
            
            public global::System.Nullable<bool> ShowVideoConf;
            
            public global::TERSApplication.Web.TrainingEvent TrainingEvent;
        }
    }
    
    [global::System.ComponentModel.DataAnnotations.MetadataTypeAttribute(typeof(global::TERSApplication.Web.Program.ProgramMetadata))]
    public partial class Program : global::System.Data.Objects.DataClasses.EntityObject {
        
        public Program() {
        }
        
        internal sealed class ProgramMetadata {
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.Catalog> Catalogs;
            
            public string CCEmail;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.Contact> Contacts;
            
            public global::System.Nullable<global::System.DateTime> CreateDate;
            
            public int CreatedByID;
            
            public string Division;
            
            public string ModifyBy;
            
            public global::System.Nullable<global::System.DateTime> ModifyDate;
            
            public string OfficeCode;
            
            public string ProgramDescription;
            
            public int ProgramID;
            
            public string ProgramName;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.TrainingEvent> TrainingEvents;
        }
    }
    
    [global::System.ComponentModel.DataAnnotations.MetadataTypeAttribute(typeof(global::TERSApplication.Web.Region.RegionMetadata))]
    public partial class Region : global::System.Data.Objects.DataClasses.EntityObject {
        
        public Region() {
        }
        
        internal sealed class RegionMetadata {
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.Occurrence> Occurrences;
            
            public string RegionFullName;
            
            public int RegionID;
            
            public string RegionName;
            
            public int TimeZoneID;
            
            public string TimeZoneName;
        }
    }
    
    public sealed class RegistrationData {
        
        public RegistrationData() {
        }
        
        [global::System.ComponentModel.DataAnnotations.KeyAttribute()]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessageResourceName="ValidationErrorRequiredField", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(Order=0, Name="UserNameLabel", ResourceType=typeof(global::TERSApplication.Web.Resources.RegistrationDataResources))]
        [global::System.ComponentModel.DataAnnotations.RegularExpressionAttribute("^[a-zA-Z0-9_]*$", ErrorMessageResourceName="ValidationErrorInvalidUserName", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        public string UserName {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        [global::System.ComponentModel.DataAnnotations.KeyAttribute()]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessageResourceName="ValidationErrorRequiredField", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(Order=2, Name="EmailLabel", ResourceType=typeof(global::TERSApplication.Web.Resources.RegistrationDataResources))]
        [global::System.ComponentModel.DataAnnotations.RegularExpressionAttribute("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4" +
            "}|[0-9]{1,3})(\\]?)$", ErrorMessageResourceName="ValidationErrorInvalidEmail", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        public string Email {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessageResourceName="ValidationErrorRequiredField", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(Order=3, Name="PasswordLabel", Description="PasswordDescription", ResourceType=typeof(global::TERSApplication.Web.Resources.RegistrationDataResources))]
        [global::System.ComponentModel.DataAnnotations.RegularExpressionAttribute("^.*[^a-zA-Z0-9].*$", ErrorMessageResourceName="ValidationErrorBadPasswordStrength", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        [global::System.ComponentModel.DataAnnotations.StringLengthAttribute(50, MinimumLength=7, ErrorMessageResourceName="ValidationErrorBadPasswordLength", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        public string Password {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(Order=1, Name="FriendlyNameLabel", Description="FriendlyNameDescription", ResourceType=typeof(global::TERSApplication.Web.Resources.RegistrationDataResources))]
        public string FriendlyName {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessageResourceName="ValidationErrorRequiredField", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(Order=5, Name="SecurityQuestionLabel", ResourceType=typeof(global::TERSApplication.Web.Resources.RegistrationDataResources))]
        public string Question {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessageResourceName="ValidationErrorRequiredField", ErrorMessageResourceType=typeof(global::TERSApplication.Web.Resources.ErrorResources))]
        [global::System.ComponentModel.DataAnnotations.DisplayAttribute(Order=6, Name="SecurityAnswerLabel", ResourceType=typeof(global::TERSApplication.Web.Resources.RegistrationDataResources))]
        public string Answer {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
    }
    
    [global::System.ComponentModel.DataAnnotations.MetadataTypeAttribute(typeof(global::TERSApplication.Web.TrainingEvent.TrainingEventMetadata))]
    public partial class TrainingEvent : global::System.Data.Objects.DataClasses.EntityObject {
        
        public TrainingEvent() {
        }
        
        internal sealed class TrainingEventMetadata {
            
            public global::System.Nullable<global::System.DateTime> CreateDate;
            
            public int CreatedByID;
            
            public global::System.Nullable<int> DaysBeforeSendingInvite;
            
            public global::System.Nullable<bool> EmailSent;
            
            public int EventID;
            
            public string EventName;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.InvitedEmail> InvitedEmails;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.InvitedEmployee> InvitedEmployees;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.InviteEmailAttachment> InviteEmailAttachments;
            
            public string InviteEmailBody;
            
            public string InviteEmailSubject;
            
            public bool IsActive;
            
            public bool IsPublic;
            
            public string ModifyBy;
            
            public global::System.Nullable<global::System.DateTime> ModifyDate;
            
            public global::System.Data.Objects.DataClasses.EntityCollection<global::TERSApplication.Web.Occurrence> Occurrences;
            
            public global::System.Nullable<decimal> OrgNo;
            
            public global::TERSApplication.Web.Program Program;
            
            public int ProgramID;
        }
    }
    
    public partial class User : global::System.Web.Ria.ApplicationServices.UserBase {
        
        public User() {
        }
        
        [global::System.Web.Ria.ApplicationServices.ProfileUsageAttribute(IsExcluded=true)]
        public string DisplayName {
            get {
                throw new System.NotImplementedException();
            }
        }
        
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string FriendlyName {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
    }
    
    [global::System.Web.Ria.EnableClientAccessAttribute()]
    public class UserRegistrationService : global::System.Web.DomainServices.DomainService {
        
        public UserRegistrationService() {
        }
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public void AddUser(global::TERSApplication.Web.RegistrationData user) {
            throw new System.NotImplementedException();
        }
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public global::System.Collections.Generic.IEnumerable<global::TERSApplication.Web.RegistrationData> GetUsers() {
            throw new System.NotImplementedException();
        }
    }
}
namespace TERSApplication.Web.Services {
    
    
    [global::System.Web.Ria.EnableClientAccessAttribute()]
    public class EventServices : global::System.Web.DomainServices.Providers.LinqToEntitiesDomainService<global::TERSApplication.Web.TrainingEventRegistrationEntities> {
        
        public EventServices() {
        }
        
        public global::System.Linq.IQueryable<global::TERSApplication.Web.EventType> GetEventTypes() {
            throw new System.NotImplementedException();
        }
        
        public global::System.Linq.IQueryable<global::TERSApplication.Web.Occurrence> GetOccurrences() {
            throw new System.NotImplementedException();
        }
        
        public global::System.Linq.IQueryable<global::TERSApplication.Web.Program> GetPrograms() {
            throw new System.NotImplementedException();
        }
        
        public global::System.Linq.IQueryable<global::TERSApplication.Web.Region> GetRegions() {
            throw new System.NotImplementedException();
        }
        
        public global::System.Linq.IQueryable<global::TERSApplication.Web.TrainingEvent> GetTrainingEvents() {
            throw new System.NotImplementedException();
        }
        
        public global::System.Linq.IQueryable<global::TERSApplication.Web.EventReadOnly> GetTrainingEventsreadOnlyBindable() {
            throw new System.NotImplementedException();
        }
    }
}
