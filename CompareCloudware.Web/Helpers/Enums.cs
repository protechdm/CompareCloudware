using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.Helpers
{
    public enum HeaderTagType
    {
        H1 = 1,
        H2 = 2
    }

    public enum CarouselType
    {
        Home = 1,
        Category = 2,
        Social = 3
    }

    public enum ContentDataPage
    {
        Home = 1,
        Category = 2,
        CloudwareExplained = 3,
        Corporate = 4,
        PartnerProgramme = 5
    }

    public enum PartnerProgrammeTypeEnum
    {
        NotSet = 0,
        BusinessPartner = 1,
        StrategicPartner = 2,
        ReferRewardPartner = 3
    }

    public enum PersonTypeEnum
    {
        NotSet = 0,
        ProspectVendor = 1,
        User = 2,
        Colleague = 3
    }

    public enum RequestTypeEnum : int
    {
        NotSet = 0,
        FreeTrial = 1,
        BuyNow = 2,
        EmailPage = 3,
        BusinessPartner = 4,
        StrategicPartner = 5,
        ReferRewardPartner = 6,
        SendToColleague = 7
    }

}