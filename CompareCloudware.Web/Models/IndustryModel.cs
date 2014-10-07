using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Web.Models
{

    public class IndustryModel
    {
        public int IndustryID { get; set; }
        public int code { get; set; }
        //public virtual List<string> groups { get; set; }
        [Display(Name = "Industry")]
        public string description { get; set; }
    }

    public class AllIndustries
    {
        public IndustryModel[] Industries;
    }

    //public class getAvailableHotelResponse
    //{
    //    //public int responseId;
    //    public Industry[] Industries;
    //    //public int totalFound;
    //    //public string searchId;
    //}

    //public class availableHotel
    //{
    //    public string code;
    //    public string description;
    //}
}

