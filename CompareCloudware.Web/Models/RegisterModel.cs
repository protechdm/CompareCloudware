namespace CompareCloudware.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;
    using System.Web.Mvc;

    public class RegisterModel
    {
        [DataType(DataType.Password), Display(Name="Confirm password"), Compare("Password", ErrorMessage="The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.EmailAddress), Required, Display(Name="Email address")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage="The {0} must be at least {2} characters long.", MinimumLength=6), Required, Display(Name="Password"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="User name"), Required]
        public string UserName { get; set; }
    }
}

