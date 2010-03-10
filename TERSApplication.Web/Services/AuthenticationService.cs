namespace TERSApplication.Web
{
    using System.Security.Authentication;
    using System.Web.DomainServices;
    using System.Web.Ria;
    using System.Web.Ria.ApplicationServices;
    using System.Threading;

    /// <summary>
    ///    RIA Services DomainService responsible for authenticating users when
    ///    they try to log on to the application.
    ///    
    ///    Most of the functionality is already provided by the base class
    ///    AuthenticationBase
    /// </summary>
    [EnableClientAccess]
    public class AuthenticationService : AuthenticationBase<User> { }
}
