namespace CompareCloudware.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class LogOnModel
    {
        [Required, Display(Name="Password"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="Remember me?")]
        public bool RememberMe { get; set; }

        [Required, Display(Name="User name")]
        public string UserName { get; set; }
    }
}

