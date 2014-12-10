using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Person
    public class Person
    {
        public virtual int PersonID { get; set; }
        public virtual string Forename { get; set; }
        public virtual string Surname { get; set; }
        public virtual string EMail { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string Company { get; set; }
        public virtual int? NumberOfEmployees { get; set; }
        public virtual string Position { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string PersonAddress1 { get; set; }
        public virtual string PersonAddress2 { get; set; }
        public virtual string PersonRegion { get; set; }
        public virtual string PersonCountry { get; set; }
        public virtual string PersonPostCode { get; set; }
        public virtual int? AccountsPersonID { get; set; }
        public virtual DateTime? LastLoggedIn { get; set; }
        public virtual bool? IsAdministrator { get; set; }
        public virtual bool? IsEditor { get; set; }
        public virtual bool? IsFinanceContact { get; set; }
        public virtual bool? IsInUserGroup { get; set; }
        public virtual Status PersonStatus { get; set; }
        public virtual PersonType PersonType { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
