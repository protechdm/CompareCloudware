namespace CompareCloudware.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class User : IUser
    {
        public User()
        {
            this.Roles = new List<UserRole>();
        }

        public IEnumerable<UserRole> Roles { get; set; }
    }
}

