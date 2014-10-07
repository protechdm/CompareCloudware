namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class ReservationViewModel : BaseModel
    {
        public ReservationViewModel()
        {
        }

        public ReservationViewModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public string SearchInput { get; set; }
    }
}

