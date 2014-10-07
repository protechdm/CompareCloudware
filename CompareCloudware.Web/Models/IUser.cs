namespace CompareCloudware.Web.Models
{
    using System;
    using System.Collections.Generic;

    public interface IUser
    {
        IEnumerable<UserRole> Roles { get; set; }
    }
}

