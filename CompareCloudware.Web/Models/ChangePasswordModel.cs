namespace CompareCloudware.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;
    using System.Web.Mvc;

    public class ChangePasswordModel
    {
        [DataType(DataType.Password), Display(Name="Confirm new password"), Compare("NewPassword", ErrorMessage="The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [StringLength(100, ErrorMessage="The {0} must be at least {2} characters long.", MinimumLength=6), Display(Name="New password"), Required, DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name="Current password"), Required, DataType(DataType.Password)]
        public string OldPassword { get; set; }
    }
}

