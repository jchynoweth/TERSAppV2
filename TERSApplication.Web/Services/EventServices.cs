
namespace TERSApplication.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.Web.DomainServices;
    using System.Web.DomainServices.Providers;
    using System.Web.Ria;
    using System.Web.Ria.Services;
    using TERSApplication.Web;


    // Implements application logic using the TrainingEventRegistrationEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class EventServices : LinqToEntitiesDomainService<TrainingEventRegistrationEntities>
    {

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<EventType> GetEventTypes()
        {
            return this.ObjectContext.EventTypes;
        }

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<Occurrence> GetOccurrences()
        {
            return this.ObjectContext.Occurrences;
        }

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<Program> GetPrograms()
        {
            return this.ObjectContext.Programs;
        }

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<Region> GetRegions()
        {
            return this.ObjectContext.Regions;
        }

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<TrainingEvent> GetTrainingEvents()
        {
            return this.ObjectContext.TrainingEvents;
        }

        
        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<EventReadOnly> GetTrainingEventsreadOnlyBindable()
        {
          
           var res = this.ObjectContext.TrainingEvents.Select(t => new EventReadOnly() {  CreatedBy = t.vwEmployee.FullName, EventID = t.EventID, Status = "Active", EventName = t.EventName });
           return res;
        }

        
       
       
    }
}


