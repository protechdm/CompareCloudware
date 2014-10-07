namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class HeaderModel : IBaseModel
    {
        private ICustomSession _session;

        public HeaderModel()
        {
            this._session = new CompareCloudware.Web.CustomSession();
        }

        public HeaderModel(ICustomSession session)
        {
            this._session = session;
        }

        public IEnumerable<CategoryModel> Categories { get; set; }

        public ICustomSession CustomSession
        {
            get
            {
                return this._session;
            }
            set
            {
                this._session = value;
            }
        }

        [UIHint("SearchTextBox"), Display(Name="Buy now"), DataType(DataType.Text)]
        public string SearchText { get; set; }

        public CloudApplicationRegistrationAndUpdateModel CloudApplicationRegistrationModel { get; set; }
    }
}

