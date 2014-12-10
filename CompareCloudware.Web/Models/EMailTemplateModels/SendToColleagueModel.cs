using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.Models.EMailTemplateModels
{
    public class SendToColleagueModel
    {
        public string RecommenderForename { get; set; }
        public string RecommenderSurname { get; set; }
        public string ColleagueForename { get; set; }
        public string ColleagueSurname { get; set; }
        public string ColleagueEmail { get; set; }
        public string CloudApplicationName { get; set; }
        public string CloudApplicationURL { get; set; }
        public string Message { get; set; }
    }
}