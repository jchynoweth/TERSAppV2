﻿namespace TERSApplication.Web
{
    using System.Runtime.Serialization;
    using System.Web.Ria.ApplicationServices;

    public partial class User : UserBase
    {
        //// NOTE: Profile properties can be added for use in Silverlight application.
        //// To enable profiles, edit the appropriate section of web.config file.
        ////
        //// [DataMember]
        //// public string MyProfileProperty { get; set; }

        [DataMember]
        public string FriendlyName { get; set; }
    }
}
