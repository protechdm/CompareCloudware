using CompareCloudware.Web;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
//using EntityFramework;

namespace CompareCloudware.Web.Models
{
    public class VendorModel : BaseModel
    {
        public VendorModel()
        {
        }

        public VendorModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        //[Compare("NewPassword", ErrorMessage="The new password and confirmation password do not match."), Display(Name="Confirm new password"), DataType(DataType.Password)]
        //public string ConfirmPassword { get; set; }

        //[DataType(DataType.Password), Display(Name="New password"), Required, StringLength(100, ErrorMessage="The {0} must be at least {2} characters long.", MinimumLength=6)]
        //public string NewPassword { get; set; }

        //[Display(Name="Current password"), Required, DataType(DataType.Password)]
        //public string OldPassword { get; set; }

        public int? VendorID { get; set; }

        public byte[] VendorLogo { get; set; }

        [Display(Name = "Vendor Logo:"), MaxLength(50)]
        public string VendorLogoFileName { get; set; }

        [Display(Name = "Vendor URL:"), MaxLength(50)]
        public string VendorLogoFullURL { get; set; }

        [Display(Name="Vendor name:"), MaxLength(50)]
        public string VendorName { get; set; }
    }
}

