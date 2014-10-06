using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class TermsAndConditionsData
    {
        public static bool PumpTermsConditionsData(QueryRepository repository)
        {
            string PORTRAIT_FILEPATH = "J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Portraits\\";
            string PORTRAIT_ANDREW = "andrewmiller.jpg";
            string PORTRAIT_CAROLINE = "carolineread.jpg";
            string PORTRAIT_GARY = "garygould.jpg";
            string PORTRAIT_IAN = "ianwilson.jpg";

            bool retVal = true;

            #region TERMSANDCONDITIONS
            TermCondition tc;
            string data;
            string compositeID;
            int maxCols = 16;

            bool pumpSection1 = false;
            bool pumpSection2 = false;
            bool pumpSection3 = false;
            bool pumpSection4 = false;
            bool pumpSection5 = false;
            bool pumpSection6 = false;
            bool pumpSection7 = false;
            bool pumpSection8 = false;
            bool pumpSection9 = false;
            bool pumpSection10 = false;
            bool pumpSection11 = false;
            bool pumpSection12 = false;
            bool pumpSection13 = false;
            bool pumpSection14 = false;
            bool pumpSection15 = false;

            #region PROVIDER

            #region PROVIDER TITLE
            data = "CLOUD PROVIDER TERMS AND CONDITIONS OF SERVICE";
            tc = new TermCondition
            {
                SectionText1 = data,
                DisplayID = 1,
                Indent = 0,
                ColumnSpan = maxCols,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region PROVIDER SECTION 1
            data = "1.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 2,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 1,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Application";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 2,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "1.1";
            tc = new TermCondition
            {
                ParentDisplayID = 2,
                DisplayID = 3,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 1,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "These Terms and Conditions shall apply to the provision of Cloud proposition promotion services by the Service Provider to the Client.";
            tc = new TermCondition
            {
                ParentDisplayID = 2,
                DisplayID = 3,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "1.2";
            tc = new TermCondition
            {
                ParentDisplayID = 2,
                DisplayID = 4,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 1,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "In the event of conflict between these Terms and Conditions and any other terms and conditions (of the Client or otherwise), the former shall prevail unless expressly otherwise agreed by the Service Provider in writing.";
            tc = new TermCondition
            {
                ParentDisplayID = 2,
                DisplayID = 4,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 2
            data = "2.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 5,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Definitions and Interpretation";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 5,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.1";
            tc = new TermCondition
            {
                ParentDisplayID = 5,
                DisplayID = 6,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "In these Terms and Conditions, unless the context otherwise requires, the following expressions have the following meanings:";
            tc = new TermCondition
            {
                ParentDisplayID = 5,
                DisplayID = 6,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Agreement\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 7,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means any agreement between the Service Provider and the Client entered into by the same which is subject to these Terms and Conditions;";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 7,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Business Day\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 8,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means a day (excluding Saturdays) on which banks generally are open for the transaction of normal banking business (other than solely for trading and settlement in Euros);";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 8,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Client\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 9,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means any individual, firm or corporate body (which expression shall, where the context so admits, include its successors and assigns) which purchases services from the Service Provider;";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 9,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Commencement Date\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 10,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means the commencement date for the Agreement as set out in the same;";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 10,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Fees\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 11,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means the fees payable by the Client under Clause 4 in accordance with the Terms of Payment;";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 11,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Services\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 12,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means the services to be provided by the Service Provider to the Client as set out in the Schedule;";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 12,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Service Provider\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 13,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            //data = "means Compare Cloudware Ltd, Compare Cloudware and/or www.comparecloudware.com and";
            data = "means Compare Cloudware Ltd, Compare Cloudware and/or ";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 13,
                Indent = 4,
                SectionText1 = data,
                SectionText2 = "www.comparecloudware.com",
                SectionText2IsURL = true,
                SectionText2URL = "www.comparecloudware.com",
                SectionText3 = " and",
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Terms Of Payment\"";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 14,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 2,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means the terms of payment of Fees as set out in the Schedule.";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 14,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 15,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Unless the context otherwise requires, each reference in these Terms and Conditions to:";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 15,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2.1";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 16,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"writing\", and any cognate expression, includes a reference to any communication effected by electronic or facsimile transmission or similar means;";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 16,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2.2";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 17,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "a statute or a provision of a statute is a reference to that statute or provision as amended or re-enacted at the relevant time;";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 17,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2.3";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 18,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"these Terms and Conditions\" is a reference to these Terms and Conditions and any Schedules as amended or supplemented at the relevant time;";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 18,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2.4";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 19,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "a Schedule is a schedule to these Terms and Conditions; and";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 19,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2.5";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 20,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "a Clause or paragraph is a reference to a Clause of these Terms and Conditions (other than the Schedules) or a paragraph of the relevant Schedule.";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 20,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2.6";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 21,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "a \"Party\" or the \"Parties\" refer to the parties to these Terms and Conditions.";
            tc = new TermCondition
            {
                ParentDisplayID = 15,
                DisplayID = 21,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.3";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 22,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The headings used in these Terms and Conditions are for convenience only and shall have no effect upon the interpretation of these Terms and Conditions.";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 22,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.4";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 23,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Words imparting the singular number shall include the plural and vice versa.";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 23,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.5";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 24,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "References to any gender shall include the other gender.";
            tc = new TermCondition
            {
                ParentDisplayID = 6,
                DisplayID = 24,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 3
            data = "3.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 25,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Services";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 25,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.1";
            tc = new TermCondition
            {
                ParentDisplayID = 25,
                DisplayID = 26,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "With effect from the Commencement Date the Service Provider shall, in consideration of the Fees being paid in accordance with the Terms of Payment, provide the Services to the Client.";
            tc = new TermCondition
            {
                ParentDisplayID = 25,
                DisplayID = 26,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.2";
            tc = new TermCondition
            {
                ParentDisplayID = 25,
                DisplayID = 27,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider will use reasonable care and skill to deliver the Services.";
            tc = new TermCondition
            {
                ParentDisplayID = 25,
                DisplayID = 27,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.3";
            tc = new TermCondition
            {
                ParentDisplayID = 25,
                DisplayID = 28,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider shall use all reasonable endeavours to complete its obligations under these Terms and Conditions";
            tc = new TermCondition
            {
                ParentDisplayID = 25,
                DisplayID = 28,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 4
            data = "4.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 29,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Client Obligations";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 29,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "4.1";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 30,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Client agrees to provide us with true, accurate, current, and complete information. You will accept the right of the Service Provider to remove any content (including, but not restricted to text, files, downloads, images, pricing) without notice or warning that is deemed inaccurate, incomplete, misleading (accidental or on purpose). The Client will accept these terms of business.  As regards to the on-boarding, the Client will promptly update the data to keep it accurate, current, and complete. If the Service Provider issues the Client with personal credentials (password), the client may not reveal it to anyone else. It is personal and non-transferable. The Client may not use anyone else's credentials (password). The Client is responsible for maintaining the confidentiality of the Clients accounts and passwords. The Client agrees to immediately notify us of any unauthorised use of the Clients passwords or accounts or any other breach or risk of breach of security. The Client also agrees to exit from your account at the end of each session. The Service Provider will not be responsible for any loss or damage that may result if you fail to comply with these requirements.";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 30,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "4.2";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 31,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Client will use the Service Providers website in accordance with these Terms of Business and applicable law. Without limiting the foregoing, The Client agrees that the Client will not use the Service Providers Website to take any of the following actions:";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 31,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Submit unlawful content according to the national, community or international law or content contrary to good faith; that violates other individuals’ fundamental or other rights (including intellectual and/or industrial property rights without authorisation),";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 32,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Submit any content that may prejudice the image, honour and reputation of the Websites, or generally any content whatsoever that we deem inappropriate.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 33,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Abuse, harass, threaten, or otherwise violate the legal right of others.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 34,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Publish, post, distribute, or disseminate any inappropriate, profane, defamatory, obscene, indecent, or unlawful content.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 35,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Transmit surveys, contests, pyramid schemes, spam, unsolicited advertising or promotional materials, or chain letters.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 36,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Interfere with or disrupt our Websites, servers, or networks.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 37,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Impersonate any person or entity, including, but not limited to, a Service Providers representative, or falsely state or otherwise misrepresent your affiliation with a person or entity.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 38,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Engage in any illegal activities.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 39,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "4.3";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 40,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Client will be held liable to Service Providers and/or third parties for any breach or violation of the said obligations and/or for any damage, ruin, overload, submission and dissemination of viruses, and interference with the proper use of materials and information included within the Service Providers Website, the information systems, documents, files and any kind of contents stored in any computer (hacking) owned by the Service Provider or any of its clients.";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 40,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "4.5";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 41,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Unauthorised access to the Service Providers website(s) is a breach of these Terms of Business and a violation of the law. The Client agrees not to access the Service Providers website(s) by any means other than through the interface that is provided by the Service Provider. The Client agrees not to use any automated means, including, without limitation, agents, robots, scripts, or spiders, to access, monitor, or copy any part of the Service Providers website.";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 41,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "4.6";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 42,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Use of the Service Provider website(s) is subject to existing applicable English laws and legal process. Nothing contained in these Terms shall limit our right to comply with governmental, court, and law-enforcement requests or requirements relating to the Clients use of the Service Providers website(s).";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 42,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "4.7";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 43,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The technology and the software underlying the Service Providers website(s) and the Services are the property of the Service Provider and the Service Providers partners. The Client agrees not to copy, modify, rent, lease, loan, sell, assign, distribute, reverse engineer, grant a security interest in, or otherwise transfer any right to the contents (texts, designs, graphics, information, database, pictures, logos, etc.), technology or software underlying the Service Providers website(s) or the Services.";
            tc = new TermCondition
            {
                ParentDisplayID = 29,
                DisplayID = 43,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region PROVIDER SECTION 5
            data = "5.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 44,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Fees";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 44,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.1";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 45,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Client agrees to pay the Fees in accordance with the Terms of Payment.";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 45,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.2";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 46,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "All sums payable by either Party pursuant to these Terms and Conditions are exclusive of any value added or other tax (except corporation tax) or other taxes on profit, for which that Party shall be additionally liable.";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 46,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.3";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 47,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The fees for Compare Cloudware marketing services are:";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 47,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Cumulus";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 48,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "FREE";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 48,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "for 1 year";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 48,
                Indent = 8,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Nimbus";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 49,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "£1,250";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 49,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "for 1 year";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 49,
                Indent = 8,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Stratus";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 50,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "£3,500";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 50,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "for 1 year";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 50,
                Indent = 8,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Alto";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 51,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "£7,500";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 51,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "for 1 year";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 51,
                Indent = 8,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Cirrus";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 52,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "£15,000";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 52,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "for 1 year";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 52,
                Indent = 8,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The full list of components of each package are listed on the Marketing packages table";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 53,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Additional costs - Costs for additional activities may be added to the above packages. These will be itemised and agreed in advance.";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 54,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.4";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 55,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The fees for Compare Cloudware sponsorship services are:";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 55,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Home page";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 56,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "£10,000";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 56,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "for 1 month";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 56,
                Indent = 8,
                SectionText1 = data,
                ColumnSpan = 2,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Category home page (x1)";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 57,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "£4,000";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 57,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "for 1 month";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 57,
                Indent = 8,
                SectionText1 = data,
                ColumnSpan = 2,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Site-wide";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 58,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "£TBD";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 58,
                Indent = 5,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The full list of components of each package are listed on the Sponsor packages table";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 59,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Additional costs - Costs for additional activities may be added to the above packages. These will be itemised and agreed in advance.";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 60,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.5";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 61,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider does not offer refunds for Marketing & Sponsorship packages cancelled after Client approval of contracts and commencement.";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 61,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.6";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 62,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "In addition to fees relating to Marketing & Sponsorships packages, the Client agrees to remunerate the Service Provider in accordance with the Clients Reseller Agreement or as set out in the Service Providers Agreement.";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 62,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.7";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 63,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Should the Client convert a lead into a sale and the Service Provider is not remunerated, as stated in the Clients Reseller Agreement or the Service Providers Agreement, then the Service Provider reserves the right to inform the primary Lead contact of the Clients citing the Service Provider’s failure to pay and possible financial instability.  The Client will be removed from the Service Provider website(s).";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 63,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.8";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 64,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider will provide the Client with leads and data to use in their own sales and marketing purpose.  Where the Client selects a free marketing package the Service Provider must be remunerated with an agreed  fee for all trial requests – whether they are converted to sales or not.";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 64,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.9";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 65,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider will be remunerated for leads, trial requests, purchases and recurring subscription revenue agreed in Clients Reseller Agreement or as set out in the Service Providers Agreement, Clients reporting system or the Clients affiliate/partner programme.  However if the client has no formalised reporting system or partner programme in place, then the Service Provider will work with the client to deliver this manually to mutually agreed guidelines.";
            tc = new TermCondition
            {
                ParentDisplayID = 44,
                DisplayID = 65,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 6
            data = "6.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 66,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Payment";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 66,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "6.1";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 67,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "All payments required to be made pursuant to these Terms and Conditions by either Party shall be made within 28 days of the date of the relevant invoice in Pounds Sterling in cleared funds to such bank in the UK as the receiving Party may from time to time nominate, without any set-off, withholding or deduction except such amount (if any) of tax as that Party is required to deduct or withhold by law.";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 67,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "6.2";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 68,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The time of payment shall be of the essence.  If the Client fails to make any payment on the due date then the Service Provider shall, without prejudice to any right which the Service Provider may have pursuant to any statutory provision in force from time to time, have the right to charge the Client interest on a daily basis at an annual rate equal to the aggregate of 5% and the base rate of Bank of England from time to time on any sum due and not paid on the due date.  Such interest shall be calculated cumulatively on a daily basis and shall run from day to day and accrue after as well as before any judgement. Alternatively, the Service Provider retains the right to withhold or withdraw the services until payment is made.";
            tc = new TermCondition
            {
                ParentDisplayID = 47,
                DisplayID = 68,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);


            #endregion

            #region PROVIDER SECTION 7
            data = "7.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 69,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Confidentiality";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 69,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.1";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 70,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Both the Service Provider and the Client shall undertake that, except as provided by sub-Clause 6.2 or as authorised in  writing by the other Party, it shall at all times during the continuance of the Agreement  and for 2 years after its termination:";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 70,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.1.1";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 71,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "keep confidential all Confidential Information;";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 71,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.1.2";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 72,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "not disclose any Confidential Information to any other party;";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 72,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.1.3";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 73,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "not use any Confidential Information for any purpose other than as contemplated by these Terms and Conditions or the Agreement;";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 73,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.1.4";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 74,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "not make any copies of, record in any way or part with possession of any Confidential Information; and";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 74,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.1.5";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 75,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "ensure that (as applicable) none of its directors, officers, employees, agents or advisers does any act which, if done by that Party, would be a breach of the provisions of sub-Clauses 7.1.1 to 7.1.4.";
            tc = new TermCondition
            {
                ParentDisplayID = 70,
                DisplayID = 75,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.2";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 76,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Subject to sub-Clause 6.3, either Party may disclose any Confidential Information to:";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 76,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.2.1";
            tc = new TermCondition
            {
                ParentDisplayID = 76,
                DisplayID = 77,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "any of their sub-contractors or suppliers;";
            tc = new TermCondition
            {
                ParentDisplayID = 76,
                DisplayID = 77,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.2.2";
            tc = new TermCondition
            {
                ParentDisplayID = 76,
                DisplayID = 78,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "any governmental or other authority or regulatory body; or";
            tc = new TermCondition
            {
                ParentDisplayID = 76,
                DisplayID = 78,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.2.3";
            tc = new TermCondition
            {
                ParentDisplayID = 76,
                DisplayID = 79,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "any of their employees or officers or those of any party described in sub-Clauses 7.2.1 or 7.2.2;";
            tc = new TermCondition
            {
                ParentDisplayID = 76,
                DisplayID = 79,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.3";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 80,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Disclosure under sub-Clause 7.2 may be made only to the extent that is necessary for the purposes contemplated by these Terms and Conditions and the Agreement, or as required by law.  In each case the disclosing Party must first inform the recipient that the Confidential Information is confidential.  Unless the recipient is a body described in sub-Clause 7.2.2 or is an authorised employee or officer of such a body, the disclosing Party must obtain and submit to the other Party a written undertaking from the recipient to keep the Confidential Information confidential and to use it only for the purposes for which the disclosure is made.";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 80,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.4";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 81,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Either Party may use any Confidential Information for any purpose, or disclose it to any other party, where that Confidential Information is or becomes public knowledge through no fault of that Party.";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 81,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.5";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 82,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "When using or disclosing Confidential Information under sub-Clause 7.4, the disclosing Party must ensure that it does not disclose any part of that Confidential Information which is not public knowledge.";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 82,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.6";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 83,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The provisions of this Clause 6 shall continue in force in accordance with their terms, notwithstanding the termination of the Agreement for any reason.";
            tc = new TermCondition
            {
                ParentDisplayID = 69,
                DisplayID = 83,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);


            #endregion

            #region PROVIDER SECTION 8
            data = "8.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 84,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Variation and Amendments";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 84,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "8.1";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 85,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "If the Client wishes to vary any details of the Schedule he must notify the Service Provider in writing as soon as possible.  The Service Provider shall endeavour to make any required changes and any additional costs thereby incurred shall be invoiced to the Client.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 85,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "8.2";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 86,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "If, due to circumstances beyond the Service Provider’s control, it has to make any change in the arrangements relating to the provision of the Services it shall notify the Client immediately.  The Service Provider shall endeavour to keep such changes to a minimum and shall seek to offer the Client arrangements as close to the original as is reasonably possible in the circumstances.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 86,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "8.3";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 87,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider may modify without previous notice the design, layout and/or configuration of these Websites, and may revise these Terms.  Any modification will be enforceable from the date of publication and any subsequent use of the Websites will be subjected to the new Terms, hence we recommend you to read them carefully.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 87,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region PROVIDER SECTION 9
            data = "9.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 88,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Termination";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 88,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 89,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Either Party may terminate the Agreement by giving written notice to the other Party if:";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 89,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.1";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 90,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "any sum owing to that Party by the other Party under any of the provisions of the Agreement is not paid within 7 days of the due date for payment;";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 90,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.2";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 91,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "the other Party commits any other breach of any of the provisions of the Agreement and, if the breach is capable of remedy, fails to remedy it within 21 days after being given written notice giving full particulars of the breach and requiring it to be remedied;";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 91,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.3";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 92,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "an encumbrancer takes possession, or where the other Party is a company, a receiver is appointed, of any of the property or assets of that other Party;";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 92,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.4";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 93,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "the other Party makes any voluntary arrangement with its creditors or, being a company, becomes subject to an administration order (within the meaning of the Insolvency Act 1986);";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 93,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.5";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 94,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "the other Party, being an individual or firm, has a bankruptcy order made against it or, being a company, goes into liquidation (except for the purposes of bona fide amalgamation or re-construction and in such a manner that the company resulting therefrom effectively agrees to be bound by or assume the obligations imposed on that other Party under this Agreement);";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 94,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.6";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 95,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "anything analogous to any of the foregoing under the law of any jurisdiction occurs in relation to the other Party;";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 95,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.7";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 96,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "the other Party ceases, or threatens to cease, to carry on business; or";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 96,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1.8";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 97,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "control of the other Party is acquired by any person or connected persons not having control of that other Party on the date of the Agreement.  For the purposes of this Clause 8, “control” and “connected persons” shall have the meanings ascribed thereto by Sections 1124 and 1122 respectively of the Corporation Tax Act 2010.";
            tc = new TermCondition
            {
                ParentDisplayID = 89,
                DisplayID = 97,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.2";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 98,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "For the purposes of sub-Clause 9.1.2, a breach shall be considered capable of remedy if the Party in breach can comply with the provision in question in all respects.";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 98,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.3";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 99,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "In the event of termination under sub-Clause 9.1 the Service Provider shall retain any sums already paid to it by the Client without prejudice to any other rights the Service Provider may have whether at law or otherwise.";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 99,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.4";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 100,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider has the right, but not the obligation, to take any of the following actions in our sole discretion at any time and for any reason without giving you any prior notice:";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 100,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Restrict, suspend, or terminate your access to all or any part of our Services.";
            tc = new TermCondition
            {
                ParentDisplayID = 100,
                DisplayID = 101,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Change, suspend, or discontinue all or any part of our Services.";
            tc = new TermCondition
            {
                ParentDisplayID = 100,
                DisplayID = 102,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Refuse, move, or remove any content that you submit to our Websites for any reason.";
            tc = new TermCondition
            {
                ParentDisplayID = 100,
                DisplayID = 103,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Deactivate or delete your accounts and all related information and files in the clients account.";
            tc = new TermCondition
            {
                ParentDisplayID = 100,
                DisplayID = 104,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Establish general practices and limits concerning use of our Websites.";
            tc = new TermCondition
            {
                ParentDisplayID = 100,
                DisplayID = 105,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Client agrees that the Service Provider will not be liable to the Client or any third party for taking any of these actions.";
            tc = new TermCondition
            {
                ParentDisplayID = 88,
                DisplayID = 106,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 10
            data = "10.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 107,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Liability and Indemnity";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 107,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "10.1";
            tc = new TermCondition
            {
                ParentDisplayID = 107,
                DisplayID = 108,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Except in respect of death or personal injury caused by the Service Provider’s negligence, the Service Provider will not by reason of any representation, implied warranty, condition or other term, or any duty at common law or under the express terms contained herein, be liable for any loss of profit or any indirect, special or consequential loss, damage, costs, expenses or other claims (whether caused by the Service Provider’s servants or agents or otherwise) in connection with the performance of its obligations under these Terms and Conditions or with the use by the Client of the Services supplied.";
            tc = new TermCondition
            {
                ParentDisplayID = 107,
                DisplayID = 108,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "10.2";
            tc = new TermCondition
            {
                ParentDisplayID = 107,
                DisplayID = 109,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Client shall indemnify the Service Provider against all damages, costs, claims and expenses suffered by the Service Provider arising from loss or damage to any equipment (including that of third parties) caused by the Client, or his agents or employees.";
            tc = new TermCondition
            {
                ParentDisplayID = 107,
                DisplayID = 109,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "10.3";
            tc = new TermCondition
            {
                ParentDisplayID = 107,
                DisplayID = 110,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider shall not be liable to the Client or be deemed to be in breach of these Terms and Conditions by reason of any delay in performing, or any failure to perform, any of the Service Provider’s obligations if the delay or failure was due to any cause beyond the Service Provider’s reasonable control.";
            tc = new TermCondition
            {
                ParentDisplayID = 107,
                DisplayID = 110,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region PROVIDER SECTION 11
            data = "11.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 111,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 11,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Force Majeure";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 111,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 11,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Neither the Client nor the Service Provider shall be liable for any failure or delay in performing their obligations under these Terms and Conditions where such failure or delay results from any cause that is beyond the reasonable control of that Party.  Such causes include, but are not limited to: power failure, Internet Service Provider failure, industrial action, civil unrest, fire, flood, storms, earthquakes, acts of terrorism, acts of war, governmental action or any other event that is beyond the control of the Party in question.";
            tc = new TermCondition
            {
                ParentDisplayID = 111,
                DisplayID = 112,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 11,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 12
            data = "12.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 113,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 12,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Waiver";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 113,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "12.1";
            tc = new TermCondition
            {
                ParentDisplayID = 113,
                DisplayID = 114,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 12,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "No waiver by the Service Provider of any breach of these Terms and Conditions by the Client shall be considered as a waiver of any subsequent breach of the same or any other provision.  A waiver of any term, provision or condition of these Terms and Conditions shall be effective only if given in writing and signed by the waiving Party and then only in the instance and for the purpose for which the waiver is given.";
            tc = new TermCondition
            {
                ParentDisplayID = 113,
                DisplayID = 114,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "12.2";
            tc = new TermCondition
            {
                ParentDisplayID = 113,
                DisplayID = 115,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 12,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "No failure or delay on the part of any Party in exercising any right, power or privilege under these Terms and Conditions shall operate as a waiver of, nor shall any single or partial exercise of any such right, power or privilege preclude, any other or further exercise of any other right, power or privilege.";
            tc = new TermCondition
            {
                ParentDisplayID = 113,
                DisplayID = 115,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region PROVIDER SECTION 13
            data = "13.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 116,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 13,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Severance";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 116,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 13,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Parties agree that, in the event that one or more of the provisions of these Terms and Conditions are found to be unlawful, invalid or otherwise unenforceable, that / those provisions shall be deemed severed from the remainder of these Terms and Conditions.  The remainder of these Terms and Conditions shall be valid and enforceable.";
            tc = new TermCondition
            {
                ParentDisplayID = 116,
                DisplayID = 117,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 13,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 14
            data = "14.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 118,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 14,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Copyright";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 118,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 14,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider reserves all copyright and any other rights (if any) which may subsist in the products of, or in connection with, the provision of the Services or facilities.  The Service Provider reserves the right to take such actions as may be appropriate to restrain or prevent infringement of such copyright.";
            tc = new TermCondition
            {
                ParentDisplayID = 118,
                DisplayID = 119,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 14,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 15
            data = "15.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 120,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Notices";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 120,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "15.1";
            tc = new TermCondition
            {
                ParentDisplayID = 120,
                DisplayID = 121,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "All notices under these Terms and Conditions shall be in writing and be deemed duly given if signed by, or on behalf of, a duly authorised officer of the Party giving the notice.";
            tc = new TermCondition
            {
                ParentDisplayID = 120,
                DisplayID = 121,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "15.2";
            tc = new TermCondition
            {
                ParentDisplayID = 120,
                DisplayID = 122,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Notices shall be deemed to have been duly given:";
            tc = new TermCondition
            {
                ParentDisplayID = 120,
                DisplayID = 122,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "15.2.1";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 123,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "when delivered, if delivered by courier or other messenger (including registered mail) during normal business hours of the recipient; or";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 123,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "15.2.2";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 124,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "when sent, if transmitted by fax or e-mail and a successful transmission report or return receipt is generated; or";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 124,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "15.2.3";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 125,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "on the fifth business day following mailing, if mailed by national ordinary mail, postage prepaid; or";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 125,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "15.2.4";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 126,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "on the tenth business day following mailing, if mailed by airmail, postage prepaid.";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 126,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "in each case addressed to the most recent address, e-mail address, or facsimile number notified to the other Party.";
            tc = new TermCondition
            {
                ParentDisplayID = 122,
                DisplayID = 127,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "15.3";
            tc = new TermCondition
            {
                ParentDisplayID = 120,
                DisplayID = 128,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Service of any document for the purposes of any legal proceedings concerning or arising out of these Terms and Conditions shall be effected by either Party by causing such document to be delivered to the other Party at its registered or principal office, or to such other address as may be notified to one Party by the other Party in writing from time to time.";
            tc = new TermCondition
            {
                ParentDisplayID = 120,
                DisplayID = 128,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 15,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region PROVIDER SECTION 16
            data = "16.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 129,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 16,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Website availability";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 129,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 16,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "16.1";
            tc = new TermCondition
            {
                ParentDisplayID = 129,
                DisplayID = 130,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 16,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Client acknowledges that 100% availability of the Service Providers website(s) is not technically feasible. However, the Service Provider will make its best efforts to keep the Websites available in the most constant possible way. Due to special maintenance, security or capacity issues, and also to some events over which the Service Provider may not influence (e.g., anomalies in public communication networks, electricity cut offs, etc.), Services provided by the Service Provider may be temporarily suspended or affected by brief anomalies.";
            tc = new TermCondition
            {
                ParentDisplayID = 129,
                DisplayID = 130,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 16,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "16.2";
            tc = new TermCondition
            {
                ParentDisplayID = 129,
                DisplayID = 131,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 16,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The Service Provider disclaim any responsibility for, and if you subscribe to one of the Service Providers marketing packages, you will not be entitled to a refund as a result of, any service outages that are caused by our maintenance on the servers or the technology that underlies the Service Providers websites, failures of our service providers (including telecommunications, hosting, and power providers), computer viruses, natural disasters or other destruction or damage of our facilities, acts of nature, war, civil disturbance, or any other cause beyond the Service Providers reasonable control.";
            tc = new TermCondition
            {
                ParentDisplayID = 129,
                DisplayID = 131,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 16,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);


            #endregion

            #region PROVIDER SECTION 17
            data = "17.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 132,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 17,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Law and Jurisdiction";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 132,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 17,
                IsBold = true,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "17.1";
            tc = new TermCondition
            {
                ParentDisplayID = 132,
                DisplayID = 133,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 17,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "These Terms and Conditions (including any non-contractual matters and obligations arising therefrom or associated therewith) shall be governed by, and construed in accordance with, the laws of England and Wales.";
            tc = new TermCondition
            {
                ParentDisplayID = 132,
                DisplayID = 133,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 17,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "17.2";
            tc = new TermCondition
            {
                ParentDisplayID = 132,
                DisplayID = 134,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 17,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Any dispute, controversy, proceedings or claim between the Parties relating to these Terms and Conditions (including any non-contractual matters and obligations arising therefrom or associated therewith) shall fall within the jurisdiction of the courts of England and Wales.";
            tc = new TermCondition
            {
                ParentDisplayID = 132,
                DisplayID = 134,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 17,
                TermConditionType = "PROVIDER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);


            #endregion

            #endregion

            #region USER

            #region USER TITLE
            data = "Terms of Use";
            tc = new TermCondition
            {
                SectionText1 = data,
                DisplayID = 1,
                Indent = 0,
                ColumnSpan = maxCols,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER TERMS OF USE
            data = "Terms of Use of ";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 2,
                Indent = 0,
                SectionText1 = data,
                SectionText2 = "www.comparecloudware.com",
                SectionText2URL = "www.comparecloudware.com",
                SectionText2IsURL = true,
                SectionText3 = " and ",
                SectionText4 = "www.comparecloudware.co.uk",
                SectionText4URL = "www.comparecloudware.co.uk",
                SectionText4IsURL = true,
                SectionText5 = " - both Compare Cloudware Ltd sites.",
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "This agreement applies as between you, the user of this web site and Compare Cloudware Ltd, the owner(s) of this web site.  Your agreement to comply with and be bound by these terms and conditions is deemed to occur upon your first use of the web site. If you do not agree to be bound by these terms and conditions, you should stop using the web site immediately.";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 3,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd is the company that owns and operates ";
            tc = new TermCondition
            {
                ParentDisplayID = 2,
                DisplayID = 4,
                Indent = 0,
                SectionText1 = data,
                SectionText2 = "www.comparecloudware.com",
                SectionText2URL = "www.comparecloudware.com",
                SectionText2IsURL = true,
                SectionText3 = " and ",
                SectionText4 = "www.comparecloudware.co.uk",
                SectionText4URL = "www.comparecloudware.co.uk",
                SectionText4IsURL = true,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd, a company incorporated under the laws of England with its registered office address at Shalford Court, 95 Springfield Road, Chelmsford, Essex, CM2 6JL.";
            tc = new TermCondition
            {
                ParentDisplayID = 2,
                DisplayID = 5,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd is registered in the UK. Compare Cloudware Ltd registered company number 07270763";
            tc = new TermCondition
            {
                ParentDisplayID = 2,
                DisplayID = 6,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 1 GENERAL
            data = "1.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 7,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = " General";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 7,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Acceptance: Use of the Sites or any services offered on these Sites ('Services') by users (“You”, “the User” or “Users”) is subject to these Terms of Use ('Terms') that expressly include our Privacy Policy. Your use of these Sites constitutes your binding acceptance of these Terms, including any modifications that we make. Your use of these Sites further involves the express and full acceptance our Privacy Policy that applies to collection and processing by Compare Cloudware Ltd of certain personal and other data provided by Users through ";
            
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 8,
                Indent = 0,
                SectionText1 = data,
                SectionText2 = "www.comparecloudware.com",
                SectionText2URL = "http://www.comparecloudware.com",
                SectionText2IsURL = true,
                SectionText3 = " and ",
                SectionText4 = "www.comparecloudware.co.uk",
                SectionText4URL = "http://www.comparecloudware.co.uk",
                SectionText4IsURL = true,
                SectionText5 = ". You understand and agree that our Services may include the sending of commercial communications to You, such as announcements and advertisements from us or from our partners.",
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Modification: We may modify without previous notice the design, layout and/or configuration of these Sites, and may revise these Terms (including the Privacy Policy). Any modification will be enforceable from the date of publication and any subsequent use of the Site will be subjected to the new Terms, hence we recommend you to read them carefully.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 9,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Additional Conditions: Some of the Services may be subject to additional posted conditions within the Sites, in particular the area for Premium Users. Your use of those Services is subject to those conditions, which are incorporated into these Terms by reference. In the event of an inconsistency between these Terms and any additional posted conditions, the provisions of the additional conditions shall prevail.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 10,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Possible Compare Cloudware Ltd Actions: We have the right, but not the obligation, to take any of the following actions in our sole discretion at any time and for any reason without giving you any prior notice:";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 11,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Restrict, suspend, or terminate your access to all or any part of our Services.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 12,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Change, suspend, or discontinue all or any part of our Services.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 13,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Refuse, move, or remove any content that you submit to our Sites for any reason.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 14,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Deactivate or delete your accounts and all related information and files in Your account.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 15,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Establish general practices and limits concerning use of our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 16,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You agree that We will not be liable to you or any third party for taking any of these actions.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 17,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Responsibility: Users acknowledge and accept that they access and use the Sites and/or the contents included within these Sites under their full responsibility. Access to the Sites and/or to the contents included within do not entail any guarantee as for the Sites and/or contents’ adequateness for particular or specific User’ aims.";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 18,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd puts every effort in presenting the most accurate product specifications, features and pricing, however we do not make any warranty as to the content on our Sites. See section 8 (No Warranty)";
            tc = new TermCondition
            {
                ParentDisplayID = 7,
                DisplayID = 19,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region USER 2 SERVICES
            data = "2.";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 20,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Services";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 20,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Comparecloudware.com provides Users with the following principal Services:";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 21,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Free User services and tools to find business and IT applications (“Applications”), compare offers, choose deployment methods, including the communication with selected Applications Providers in accordance to a variety of criteria.";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 22,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "For Application Providers, possibility for publishing their Applications and enabling them to be searched (in accordance to the selected criteria).";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 23,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            //data = "means Compare Cloudware Ltd, Compare Cloudware and/or www.comparecloudware.com and";
            data = "Advertising, lead generation (Pay-Per-Click and Pay-Per-Lead) and promotional opportunities for partners and Application Providers.";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 24,
                Indent = 0,
                SectionText1 = data,
                SectionText2 = "www.comparecloudware.com",
                SectionText2IsURL = true,
                SectionText2URL = "www.comparecloudware.com",
                SectionText3 = " and",
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Service of Alerts: free automatic alerts on offers via e-mail regarding Applications; newsletter Services or informative electronic communications about - Applications and deployment methods.";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 25,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Other services that we may deem interesting for Users, such as advice, training, professional contact network, forums, access to news.";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 26,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 3 CONTENT AVAILABLE
            data = "3.";
            tc = new TermCondition
            {
                ParentDisplayID = 27,
                DisplayID = 27,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = " Content Available on Comparecloudware.com";
            tc = new TermCondition
            {
                ParentDisplayID = 27,
                DisplayID = 27,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "IPR: Our Sites include a combination of content that we create, that our partners create, and that our users create. Some materials published on our Sites, including, but not limited to, written content, photographs, graphics, images, illustrations, marks, logos are protected by our intellectual property (copyright) or industrial property rights (such as trademarks) or those of our partners or Users.";
            tc = new TermCondition
            {
                ParentDisplayID = 27,
                DisplayID = 28,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "No license: Neither Compare Cloudware Ltd nor any of its partners or Users grants You a license nor use authorisation over its intellectual or industrial property rights or over any other right or property concerning the Site, its Services or its contents. Thus You may not modify, publish, transmit, participate in the transfer or sale of, reproduce, create derivative works of, distribute, publicly communicate, or in any way exploit any of the materials or content on our Sites in whole or in part.";
            tc = new TermCondition
            {
                ParentDisplayID = 27,
                DisplayID = 29,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "User Content: You are solely responsible for all materials, whether publicly posted or privately transmitted, that you upload, post, e-mail, transmit, or otherwise make available on our Sites ('Your Content'). You certify that you own all intellectual and industrial property rights in Your Content. You hereby grant us, our affiliates, and our partners a worldwide, irrevocable, royalty-free, nonexclusive, sub licensable license to use, reproduce, create derivative works of, publicly communicate and distribute Your Content and subsequent versions of Your Content for the purposes of (i) displaying Your Content on our Sites, (ii) distributing Your Content, either electronically or via other media, to Users.";
            tc = new TermCondition
            {
                ParentDisplayID = 27,
                DisplayID = 30,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 4 THIRD PARTY SITES
            data = "4.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 31,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Third-party sites, products, and services";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 31,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Our Sites contain links to other Internet sites owned and managed by third parties, with the aim of enabling access to information available on the internet. Compare Cloudware Ltd makes no representation whatsoever about any third party sites which you may access from our Sites. Your use of each of those sites is subject to the conditions, if any, that each of those sites has posted. We have no control over sites that are not ours, and we are not responsible for any changes of content on them. Our inclusion on our Sites of any third-party content or a link to a third-party site is for informational purposes only and is not an endorsement of that content or third-party site, that there is a commercial or any other relationship between Compare Cloudware Ltd and the owners of such third party sites or that Compare Cloudware Ltd accepts any responsibility in relation to such third party sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 32,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "We do not sell, resell, or license any of the products and services that we list, review or advertise on our Sites, and we disclaim any responsibility for or liability related to any of them. Your correspondence or related activities with third parties, including payment transactions and goods-delivery transactions, are solely between you and the relevant third party. You agree that we will not be responsible or liable for any loss or damage of any sort incurred as the result of any of your transactions with third parties. Any product order, licenses, third party warranties, questions, complaints, or claims related to any product or service take place between you and the vendor and should be directed to the appropriate vendor.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 33,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "As a regular part of our business, Compare Cloudware Ltd displays advertisements and listings from a wide variety of companies. Compare Cloudware Ltd is not in a position to arbitrate disputes between the owners of intellectual property rights and companies who advertise or list their products on our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 31,
                DisplayID = 34,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 5 USERS OBLIGATIONS
            data = "5.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 35,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "User’s Obligations";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 35,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Registration. We require our Site users to register in order to conduct a search to compare Applications. Registration is required by application providers; and from Site Users who wish to fill out a category lead form (Compare Offers and Deploy Smart) or an exclusive lead form (to obtain a personalized response to their needs) or post a review on a listing, including name, company name, email address, and phone number. This data is processed in accordance with our Privacy Policy.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 36,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Registration process and submitting reviews. If we request information from you on registration and/or reviewing a product, you agree to provide us with true, accurate, current, and complete information. You will accept these terms of use, including our Privacy Policy. As regards to registration, You will promptly update your registration data to keep it accurate, current, and complete. If we issue You personal credentials (password), you may not reveal it to anyone else. It is personal and non-transferable. You may not use anyone else's credentials (password). You are responsible for maintaining the confidentiality of your accounts and passwords. You agree to immediately notify us of any Unauthorised use of your passwords or accounts or any other breach or risk of breach of security. You also agree to exit from your accounts at the end of each session. We will not be responsible for any loss or damage that may result if you fail to comply with these requirements.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 37,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Prohibited behaviour. User will use the Sites in accordance with these Terms of Use and applicable law. Without limiting the foregoing, you agree that you will not use our Sites to take any of the following actions:";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 38,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Submit unlawful content according to the national, community or international law or content contrary to good faith; that violates other individuals’ fundamental or other rights (including intellectual and/or industrial property rights without authorisation),";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 39,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Submit any content that may prejudice the image, honour and reputation of the Sites, or generally any content whatsoever that we deem inappropriate.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 40,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Abuse, harass, threaten, or otherwise violate the legal right of others.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 41,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Publish, post, distribute, or disseminate any inappropriate, profane, defamatory, obscene, indecent, or unlawful content.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 42,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Transmit surveys, contests, pyramid schemes, spam, unsolicited advertising or promotional materials, or chain letters.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 43,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Interfere with or disrupt our Sites, servers, or networks.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 44,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Impersonate any person or entity, including, but not limited to, a Compare Cloudware Ltd representative, or falsely state or otherwise misrepresent your affiliation with a person or entity.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 45,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Engage in any illegal activities.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 46,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Users will be held liable to Compare Cloudware Ltd and/or third parties for any breach or violation of the said obligations and/or for any damage, ruin, overload, submission and dissemination of viruses, and interference with the proper use of materials and information included within the Sites, the information systems, documents, files and any kind of contents stored in any computer (hacking) owned by Compare Cloudware Ltd or any of its Users.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 47,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Unauthorised access to our Sites is a breach of these Terms and a violation of the law. You agree not to access our Sites by any means other than through the interface that is provided by Compare Cloudware Ltd for use in accessing our Sites. You agree not to use any automated means, including, without limitation, agents, robots, scripts, or spiders, to access, monitor, or copy any part of our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 48,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Use of our Sites is subject to existing applicable English laws and legal process. Nothing contained in these Terms shall limit our right to comply with governmental, court, and law-enforcement requests or requirements relating to your use of our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 49,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Use of our technologies. The technology and the software underlying our Sites and the Services are the property of Compare Cloudware Ltd and our partners. You agree not to copy, modify, rent, lease, loan, sell, assign, distribute, reverse engineer, grant a security interest in, or otherwise transfer any right to the contents (texts, designs, graphics, information, database, pictures, logos, etc.), technology or software underlying our Sites or the Services.";
            tc = new TermCondition
            {
                ParentDisplayID = 35,
                DisplayID = 50,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 6 IPR
            data = "6.";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 51,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Intellectual and Industrial Property Rights";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 51,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Subject to the exceptions in these Terms and Conditions, all Content included on the site, unless uploaded by Users, including, but not limited to, text, graphics, logos, icons, images, sound clips, video clips, data compilations, page layout, underlying code and software is the property of Compare Cloudware Ltd, or our affiliates.  By continuing to use the site you acknowledge that such material is protected by applicable United Kingdom and International intellectual property and other laws.";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 52,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You may print, reproduce, copy, distribute, store or in any other fashion re-use Content from the site for personal or educational purposes only unless otherwise indicated on the site or unless given express written permission to do so by Compare Cloudware Ltd";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 53,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "If you believe that your intellectual or industrial property (including but not limited to copyright, trademarks, industrial designs, patents, models, etc.) have been violated by Compare Cloudware Ltd or by a third party who has included material on our Sites, please provide the following Notification of Claimed Infringement only to Compare Cloudware Ltd with the following elements:";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 54,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Your personal information: name, address, telephone/mobile number and e-mail address where Compare Cloudware Ltd can contact You;";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 55,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "An identification of the work protected under the intellectual and/or industrial property that You claim has been infringed;";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 56,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "A description of the material You claim is infringing and where the material that you claim is infringing is located on the Sites (e.g. the URL of the corresponding information on our Sites);";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 57,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Acts or circumstances that unravel the unlawfulness of such activities;";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 58,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "An express and clear statement that You have a good-faith belief that the use is not authorized by the intellectual or industrial property rights owner or the law;";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 59,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "A statement by You that the information in your notice is accurate and that You are the intellectual and/or industrial property right owner or are authorized to act on the owner's behalf;";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 60,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "An electronic or physical signature of the owner or of the person authorized to act on behalf of the owner of the intellectual and/or industrial property rights.";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 61,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "It is often difficult to determine if intellectual and/or industrial property rights have been violated. We may request additional information before we remove any infringing material.";
            tc = new TermCondition
            {
                ParentDisplayID = 51,
                DisplayID = 62,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 7 DISCLAIMERS OF LIABILITY
            data = "7.";
            tc = new TermCondition
            {
                ParentDisplayID = 63,
                DisplayID = 63,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Disclaimers of liability";
            tc = new TermCondition
            {
                ParentDisplayID = 63,
                DisplayID = 63,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "General disclaimer. Users acknowledge and accept that they access and use the Sites and/or the published contents of the Sites under their full responsibility. Compare Cloudware Ltd does not guarantee or promise any specific results from use of Services provided in the Sites, in particular, it does not guarantee that requestors for help will find a provider of such help, nor that any help provided will be appropriate for them. We further disclaim any responsibility for any harm resulting from accessing any information or material on the Internet using search results from our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 63,
                DisplayID = 64,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Third party content. Our Sites contain content that we create as well as content provided by third parties. This third party or User content includes, among other things, product and services descriptions, specifications, support conditions, performance, deployment methods, pricing, reviews and associated comments.  Compare Cloudware Ltd only acts as a passive conduct for the distribution and publication of User-submitted content in the Sites and we are not responsible for the deletion, the inaccuracies or failure to display correctly of any third party information or content provided in the Sites. To the extent permitted by applicable law, we do not guarantee the accuracy, the integrity, or the quality of such third party content on our Sites. In particular, You may be exposed to content that you find offensive, indecent, or objectionable or that is inaccurate. Without limitation, we are not responsible for online reviews and comments by Users, nor for third party content included or referred to in any commercial communications which are sent out to registered Users. We have the right, but not the obligation (unless required by law or judicial authorities), to remove any content that may, in our sole discretion, violate these Terms or that is otherwise objectionable.";
            tc = new TermCondition
            {
                ParentDisplayID = 63,
                DisplayID = 65,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "We do not systematically previously review or control any submitted content, offer, review, comment, opinion or any information whatsoever provided by Users. However, if we have effective knowledge, on our own or prompted by a third party, that a content, offer, review, comment, opinion or any other information that may infringe the law, these Terms of Use or other Users and third parties’ rights has been submitted, We will remove it from the Sites, without previous notice.";
            tc = new TermCondition
            {
                ParentDisplayID = 63,
                DisplayID = 66,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 8 NO WARRANTY
            data = "8.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 67,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "No Warranty";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 67,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "We do not warrant that our Sites will be uninterrupted or error free. In addition, we do not make any warranty as to the content on our Sites. Our Sites and their content are displayed on an 'as is, as available' basis without any warranty of any kind. Any content that you obtain through our Sites is done at your own discretion and risk. To the extent permitted by applicable law, neither we nor any of our partners makes any warranty that (i) our Sites will meet your requirements, (ii) our Sites will be uninterrupted, timely, secure, or error free, (iii) the results that may be obtained from the use of our Sites will be accurate or reliable, (iv) the quality of any products, services, information, or other material that you obtain through our Sites will meet your expectations, and (v) any errors will be corrected. Neither we nor any of our partners makes any warranties of any kind, either express or implied, including, without limitation, warranties of title or implied warranties of merchantability or fitness for a particular purpose, with respect to our Sites, any content, or any of our services, tools, products, or properties. You expressly agree that You will assume the entire risk as to the quality and the performance of our Sites and the accuracy or completeness of its content.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 68,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Neither we nor our partners shall be liable for any direct, indirect, incidental, special, or consequential damages arising out of the use of or inability to use our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 69,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Some countries and/or states do not allow exclusion of implied warranties or limitation of liability for incidental or consequential damages, so the above limitations or exclusions may not apply to you. In such countries and/or states, our liability and that of our third-party content providers and their respective agents shall be limited to the greatest extent permitted by law.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 70,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 9 INDEMNITY
            data = "9.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 71,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Indemnity";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 71,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You hereby agree to indemnify, defend and hold Compare Cloudware Ltd and all of our directors, owners, employees, agents, information providers, affiliates, partners, advertisers and providers harmless from and against any and all liability, losses, costs, and expenses (including attorneys' fees) incurred by any Compare Cloudware Ltd Party in connection with any claim, including, but not limited to, a breach of these Terms, a breach of the applicable regulations and/or the infringement of rights owned by Compare Cloudware Ltd, its partners, other uses or any third party; claims for defamation, violation of rights of publicity and/or privacy, intellectual or industrial property rights infringement, arising out of:";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 72,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Your use of and/or connection to our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 73,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Any use or alleged use of your accounts or your passwords by any person, whether or not authorized by you.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 74,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The content, the quality, or the performance of content that You submit to our Sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 75,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Your violation of these Terms or applicable Regulations.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 76,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Your violation of the rights of any other person or entity.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 77,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Any submission of false, inaccurate or misleading information.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 78,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Acts that may cause direct or indirect damages to Compare Cloudware Ltd, other users or third parties.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 79,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "We reserve the right, at our own expense, to assume the exclusive defence and control of any matter for which you are required to indemnify us, and you agree to cooperate with our defence of these claims.";
            tc = new TermCondition
            {
                ParentDisplayID = 71,
                DisplayID = 80,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 10 SITE AVAILABILITY
            data = "10.";
            tc = new TermCondition
            {
                ParentDisplayID = 81,
                DisplayID = 81,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 11,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Site Availability";
            tc = new TermCondition
            {
                ParentDisplayID = 81,
                DisplayID = 81,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 11,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "User acknowledges that 100% availability of the Sites is not technically feasible. However, Compare Cloudware Ltd will make its best efforts to keep the Sites available in the most constant possible way. Due to special maintenance, security or capacity issues, and also to some events over which Compare Cloudware Ltd may not influence (e.g., anomalies in public communication networks, electricity cut offs, etc.), Services provided by Compare Cloudware Ltd may be temporally suspended or affected by brief anomalies.";
            tc = new TermCondition
            {
                ParentDisplayID = 81,
                DisplayID = 82,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 11,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "We disclaim any responsibility for, and if you subscribe to one of our Premium Services you will not be entitled to a refund as a result of, any service outages that are caused by our maintenance on the servers or the technology that underlies our Sites, failures of our service providers (including telecommunications, hosting, and power providers), computer viruses, natural disasters or other destruction or damage of our facilities, acts of nature, war, civil disturbance, or any other cause beyond our reasonable control.";
            tc = new TermCondition
            {
                ParentDisplayID = 81,
                DisplayID = 83,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 11,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region USER 11 MISCELLANEOUS
            data = "11.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 84,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 12,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Miscellaneous";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 84,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                IsBold = true,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "We may be required by law to notify you of certain events. You hereby acknowledge and consent that such notices will be effective upon our posting them on our Sites or delivering them to You through e-mail. If you do not provide us with accurate information, we cannot be held liable if we fail to notify you. You have the right to request that we provide such notices to you in paper format, and may do so by contacting  Compare Cloudware Ltd at the address set out above.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 85,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Our failure to exercise or enforce any right or provision of these Terms shall not constitute a waiver of such right or provision.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 86,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You agree that regardless of any statute or law to the contrary, any claim or cause of action arising out of or related to use of our Sites or these Terms must be filed within one (1) year after such claim or cause of action arose or be forever barred.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 87,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "These Terms including all terms, conditions, Privacy Policy and policies that are incorporated into these terms by reference, constitute the entire agreement between you and Compare Cloudware Ltd and govern your use of our Sites, superseding any prior agreements that you may have with us.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 88,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "These Terms shall be construed in accordance with the laws of England & Wales, and the parties irrevocably consent to bring any action to enforce these Terms before an arbitration panel or before a court of competent jurisdiction in England & Wales if seeking interim or preliminary relief or enforcement of an arbitration award and compliance of the Terms set forth herein.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 89,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd may elect to resolve any controversy or claim arising out of or relating to these Terms or our Sites by binding arbitration in accordance with the commercial arbitration rules of England & Wales. Any such controversy or claim shall be arbitrated on an individual basis and shall not be consolidated in any arbitration with any claim or controversy of any other party. The arbitration shall be conducted in England, and judgment on the arbitration award may be entered in any court having jurisdiction thereof. Either You or we may seek any interim or preliminary relief from a court of competent jurisdiction in England, necessary to protect the rights or the property of You or Compare Cloudware Ltd (or its agents, suppliers, and subcontractors), pending the completion of arbitration.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 90,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "If any part of these Terms is determined to be invalid or unenforceable pursuant to applicable law, then the invalid or unenforceable provision will be deemed superseded by a valid, enforceable provision that most closely matches the intent of the original provision, and the remainder of the Terms shall continue in effect.";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 91,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "If you have any queries on the Terms & Conditions, email ";
            tc = new TermCondition
            {
                ParentDisplayID = 84,
                DisplayID = 92,
                Indent = 0,
                SectionText1 = data,
                SectionText2 = "terms@comparecloudware.com",
                SectionText2MailRef = "terms@comparecloudware.com",
                SectionText2IsMailRef = true,
                ColumnSpan = maxCols,
                Section = 12,
                TermConditionType = "USER_TERMS_AND_CONDITIONS",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);


            #endregion

            #endregion

            #region DEPRECATED
            //#region PRIVACY POLICY

            //#region PRIVACY POLICY TITLE
            //data = "Privacy Policy";
            //tc = new TermCondition
            //{
            //    SectionText1 = data,
            //    DisplayID = 1,
            //    Indent = 0,
            //    ColumnSpan = maxCols,
            //    IsBold = true,
            //    TermConditionType = "PRIVACY_POLICY",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region PRIVACY POLICY
            //data = "Privacy Policy of ";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 1,
            //    DisplayID = 2,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "www.comparecloudware.com",
            //    SectionText2URL = "www.comparecloudware.com",
            //    SectionText2IsURL = true,
            //    SectionText3 = ", a Compare Cloudware Ltd site",
            //    ColumnSpan = maxCols,
            //    Section = 1,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "This agreement applies as between you, the user of this web site and Compare Cloudware Ltd, the owner(s) of this web site.  Your agreement to comply with and be bound by these terms and conditions is deemed to occur upon your first use of the web site. If you do not agree to be bound by these terms and conditions, you should stop using the web site immediately.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 1,
            //    DisplayID = 3,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 1,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Compare Cloudware Ltd is the company that owns and operates ";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 2,
            //    DisplayID = 4,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "www.comparecloudware.com",
            //    SectionText2URL = "www.comparecloudware.com",
            //    SectionText2IsURL = true,
            //    SectionText3 = " and ",
            //    SectionText4 = "www.comparecloudware.co.uk",
            //    SectionText4URL = "www.comparecloudware.co.uk",
            //    SectionText4IsURL = true,
            //    ColumnSpan = maxCols,
            //    Section = 1,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Compare Cloudware Ltd, a company incorporated under the laws of England with its registered office address at Shalford Court, 95 Springfield Road, Chelmsford, Essex, CM2 6JL.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 2,
            //    DisplayID = 5,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 1,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Compare Cloudware Ltd is registered in the UK. Compare Cloudware Ltd registered company number 07270763";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 2,
            //    DisplayID = 6,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 1,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region BACKGROUND
            //data = "Background";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 7,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 2,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "This Policy applies as between you, the User of this Web Site and Compare Cloudware Ltd the owner and provider of this Web Site.  This Policy applies to our use of any and all Data collected by us in relation to your use of the Web Site and any Services or Systems therein.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 7,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 1 DEFINITIONS & INTERPRETATION
            //data = "1.";

            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 8,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Definitions and Interpretation";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 9,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "In this Policy the following terms shall have the following meanings:";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 10,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Account";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 11,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means collectively the personal information, Payment Information and credentials used by Users to access Material and / or any communications System on the Web Site;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 12,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Content";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 13,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means any text, graphics, images, audio, video, software, data compilations and any other form of information capable of being stored in a computer that appears on or forms part of this Web Site;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 14,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Cookie";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 15,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means a small text file placed on your computer by www.comparecloudware.com when you visit certain parts of this Web Site.  This allows us to identify recurring visitors and to analyse their browsing habits within the Web Site.  Where e-commerce facilities are provided, Cookies may be used to store your company, personal and/or payment details for subscription services.  Further details are contained in Clause 10 and Schedule 1 of this Policy;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 16,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Data";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 17,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means collectively all information that you submit to the Web Site.  This includes, but is not limited to, Account details and information submitted using any of our Services or Systems;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 18,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Compare Cloudware";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 7,
            //    DisplayID = 19,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 2,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means www.comparecloudware.com, Compare Cloudware or Compare Cloudware Ltd a company incorporated under the laws of England with its registered office address at Shalford Court, 95 Springfield Road, Chelmsford, Essex, CM2 6JL.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 20,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 3,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Service";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 20,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 3,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means collectively any online facilities, tools, services or information that Compare Cloudware Ltd makes available through the Web Site either now or in the future;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 21,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 3,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "System";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 22,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 3,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means any online communications infrastructure that Compare Cloudware Ltd makes available through the Web Site either now or in the future.  This includes, but is not limited to, web-based email, message boards, live chat facilities and email links;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 23,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 3,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            ////data = "means Compare Cloudware Ltd, Compare Cloudware and/or www.comparecloudware.com and";
            //data = "User / Users";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 24,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "www.comparecloudware.com",
            //    SectionText2IsURL = true,
            //    SectionText2URL = "www.comparecloudware.com",
            //    SectionText3 = " and",
            //    ColumnSpan = maxCols,
            //    Section = 3,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means any third party that accesses the Web Site and is not employed by Compare Cloudware Ltd and acting in the course of their employment; and";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 25,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 3,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Web Site";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 20,
            //    DisplayID = 26,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 3,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "means the website that you are currently using (www.comparecloudware.com) and any sub-domains of this site (e.g. subdomain.<<URL>>) unless expressly excluded by their own terms and conditions.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 27,
            //    DisplayID = 27,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 4,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 2. DATA COLLECTED
            //data = "2.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 27,
            //    DisplayID = 27,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 4,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Data Collected";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 27,
            //    DisplayID = 28,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 4,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Without limitation, any of the following Data may be collected:";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 27,
            //    DisplayID = 29,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 4,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 27,
            //    DisplayID = 30,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 4,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "name;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 31,
            //    DisplayID = 31,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 5,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.2";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 31,
            //    DisplayID = 31,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 5,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "date of birth";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 31,
            //    DisplayID = 32,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 5,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.3";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 31,
            //    DisplayID = 33,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 5,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "gender;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 31,
            //    DisplayID = 34,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 5,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.4";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 35,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 6,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "job title;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 35,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.5";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 36,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "profession;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 37,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.6";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 38,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "contact information such as email addresses and telephone numbers;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 39,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.7";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 40,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "demographic information such as post code, preferences and interests;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 41,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.8";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 42,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "financial information such as credit / debit card numbers;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 43,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.9";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 44,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "IP address (automatically collected);";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 45,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.10";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 46,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "web browser type and version (automatically collected);";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 47,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.11";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 48,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "operating system (automatically collected);";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 49,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.12";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 35,
            //    DisplayID = 50,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 6,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "a list of URLS starting with a referring site, your activity on this Web Site, and the site you exit to (automatically collected); and";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 51,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 7,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.13";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 51,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Cookie information (see clause 10 below).";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 52,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "2.14";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 53,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Content relating to the marketing of cloudware services";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 54,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 3. OUR USE OF DATA
            //data = "3.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 55,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Our Use of Data";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 56,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 57,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Any personal Data you submit will be retained by Compare Cloudware Ltd for as long as you use the Services and Systems provided on the Web Site.  Data that you may submit through any communications System that we may provide may be retained for a longer period of up to 10 years.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 58,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.2";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 59,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Unless we are obliged or permitted by law to do so, and subject to Clause 4, your Data will not be disclosed to third parties.  This does not include our affiliates and / or other companies within our group.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 60,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.3";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 61,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "The data we collect is processed for the purposes indicated in our Terms of Use, including without limitation management of the Web Site and Users, matching Application providers with Users that are willing to learn about products and services, displaying relevant content on our Web Site, contacting Users and sending commercial communications, and such other specific purposes indicated or implicit in each part of the Site.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 51,
            //    DisplayID = 62,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 7,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.4";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 63,
            //    DisplayID = 63,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 8,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "By filling in and sending your data to Compare Cloudware Ltd, you expressly consent to receive communications regarding the subject matter of the Site and other services. These commercial communications, including alerts, notices, newsletters, offers and promotions, will be always sent by Compare Cloudware Ltd, or by Application Providers to whom you have requested your data to be sent in relation to a request, lead or Application";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 63,
            //    DisplayID = 63,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 8,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.5";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 63,
            //    DisplayID = 64,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 8,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "If you do not wish to receive information form this Web Site and expressly opt out by sending a notification to optout@comparecloudware.com";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 63,
            //    DisplayID = 65,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 8,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.6";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 63,
            //    DisplayID = 66,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 8,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "All personal Data is stored securely in accordance with the principles of the Data Protection Act 1998. For more details on security, see clause 9 below.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 67,
            //    DisplayID = 67,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 9,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.7";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 67,
            //    DisplayID = 67,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 9,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Any or all of the above Data may be required by us from time to time in order to provide you with the best possible service and experience when using our Web Site.  Specifically, Data may be used by us for the following reasons:";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 67,
            //    DisplayID = 68,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 9,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.7.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 67,
            //    DisplayID = 69,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 9,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "internal record keeping;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 67,
            //    DisplayID = 70,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 9,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.7.2";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 71,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 10,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "improvement of our products / services;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 71,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.7.3";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 72,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "transmission by email of promotional materials that may be of interest to you;";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 73,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "3.7.4";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 74,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "contact for market research purposes which may be done using email, telephone, fax or mail.  Such information may be used to customise or update the Web Site.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 75,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 4. 3RD PARTY WEB SITES AND SERVICES
            //data = "4.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 76,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Third Party Web Sites and Services";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 77,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Compare Cloudware Ltd may, from time to time, employ the services of other parties for dealing with matters that may include, but are not limited to, payment handling, delivery of purchased items, search engine facilities, advertising and marketing.  The providers of such services may have access to certain personal Data provided by Users of this Web Site. Any Data used by such parties is used only to the extent required by them to perform the services that Compare Cloudware Ltd requests.  Any use for other purposes is strictly prohibited.  Furthermore, any Data that is processed by third parties must be processed within the terms of this Policy and in accordance with the Data Protection Act 1998.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 78,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "www.comparecloudware.com contains links to other web Sites whose information practices may be different than ours.  We recommend visitors to consult the respective policies of these third parties for more information on their information practices. Compare  Cloudware Ltd privacy policy does not apply to, and we have no control over the activities or information that is submitted to, nor collected and processed by, these third parties.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 79,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "We may partner with identified third parties however we do not provide any personally identifiable information to these third parties without your consent";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 71,
            //    DisplayID = 80,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 10,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 5. CHANGE OF BUSINESS OWNERSHIP & CONTROL
            //data = "5.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 81,
            //    DisplayID = 81,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 11,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Changes of Business Ownership and Control";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 81,
            //    DisplayID = 81,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 11,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "5.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 81,
            //    DisplayID = 82,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 11,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Compare Cloudware Ltd may, from time to time, expand or reduce its business and this may involve the sale of certain divisions or the transfer of control of certain divisions to other parties.  Data provided by Users will, where it is relevant to any division so transferred, be transferred along with that division and the new owner or newly controlling party will, under the terms of this Policy, be permitted to use the Data for the purposes for which it was supplied by you.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 81,
            //    DisplayID = 83,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 11,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "In the event that any Data submitted by Users will be transferred in such a manner, you will not be contacted in advance and informed of the changes.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 84,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = 1,
            //    Section = 12,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 6. CONTROLLING ACCESS TO YOUR DATA
            //data = "6.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 84,
            //    Indent = 1,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    IsBold = true,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Controlling Access to your Data";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 85,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "6.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 86,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Wherever you are required to submit Data, you will be given options to restrict our use of that Data.  This may include the following:";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 87,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "6.1.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 88,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "use of Data for direct marketing purposes; and";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 89,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "6.1.2";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 90,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "sharing Data with third parties.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 91,
            //    Indent = 0,
            //    SectionText1 = data,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 7. YOUR RIGHT TO WITHHOLD INFORMATION
            //data = "7.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Your Right to Withhold Information";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "7.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "You may access certain areas of the Web Site without providing any Data at all.  However, to use all Services and Systems available on the Web Site you may be required to submit Account information or other Data.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "7.2";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "7.2	You may restrict your internet browser’s use of Cookies.  For more information see clause 10.4 below.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 8. ACCESSING YOUR OWN DATA
            //data = "8.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Accessing your own Data";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "8.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "You may access your Account at any time to view or amend the Data.  You may need to modify or update your Data if your circumstances change.  Additional Data as to your marketing preferences may also be stored and you may change this at any time.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "8.2";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "You have the right to ask for a copy of your personal Data on payment of a small fee.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 9. SECURITY
            //data = "9.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Security";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "9.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Data security is of great importance to Compare Cloudware Ltd and to protect your Data we have put in place suitable physical, electronic and managerial procedures to safeguard and secure Data collected online.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 10. COOKIES
            //data = "10.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Cookies";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "10.1";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "www.comparecloudware.com may set and access Cookies on your computer.  Cookies that may be placed on your computer are detailed in Schedule 1 to this Policy.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "10.2";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "A Cookie is a small file that resides on your computer’s hard drive and often contains an anonymous unique identifier and is accessible only by the web site that placed it there, not any other sites.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "10.3";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "You may delete Cookies, however you may lose any information that enables you to access the Web Site more quickly.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "10.4";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "You can choose to enable or disable Cookies in your web browser.  By default, your browser will accept Cookies, however this can be altered.  For further details please consult the help menu in your browser.  Disabling Cookies may prevent you from using the full range of Services available on the Web Site.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);
            //#endregion

            //#region 11. CHANGES TO THIS POLICY
            //data = "11.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Changes to this Policy";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "Compare Cloudware Ltd reserves the right to change this Privacy Policy as we may deem necessary from time to time or as may be required by law.  Any changes will be immediately posted on the Web Site and you are deemed to have accepted the terms of the Policy on your first use of the Web Site following the alterations.";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);

            //data = "If you have any queries on the Terms & Conditions, email privacy@comparecloudware.com";
            //tc = new TermCondition
            //{
            //    ParentDisplayID = 84,
            //    DisplayID = 92,
            //    Indent = 0,
            //    SectionText1 = data,
            //    SectionText2 = "terms@comparecloudware.com",
            //    SectionText2MailRef = "terms@comparecloudware.com",
            //    SectionText2IsMailRef = true,
            //    ColumnSpan = maxCols,
            //    Section = 12,
            //    TermConditionType = "USER_TERMS_AND_CONDITIONS",
            //};
            //repository.AddTermCondition(tc);




            //#endregion

            //#endregion
            #endregion

            #endregion

            return retVal;
        }

        public static bool PumpPrivacyPolicyData(QueryRepository repository)
        {

            bool retVal = true;

            #region PRIVACYPOLICY
            TermCondition tc;
            string data;
            int maxCols = 16;

            #region TITLE
            data = "Privacy Policy";
            tc = new TermCondition
            {
                SectionText1 = data,
                DisplayID = 1,
                Indent = 0,
                ColumnSpan = maxCols,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region SECTION 0
            data = "Privacy Policy of www.comparecloudware.com, a Compare Cloudware Ltd site";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 2,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 0,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "This agreement applies as between you, the user of this web site and Compare Cloudware Ltd, the owner(s) of this web site.  Your agreement to comply with and be bound by these terms and conditions is deemed to occur upon your first use of the web site. If you do not agree to be bound by these terms and conditions, you should stop using the web site immediately.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 3,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 0,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd is the company that owns and operates www.comparecloudware.com";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 4,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 0,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd, a company incorporated under the laws of England with its registered office address at Shalford Court, 95 Springfield Road, Chelmsford, Essex, CM2 6JL.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 5,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 0,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd is registered in the UK. Compare Cloudware Ltd registered company number 07270763.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 6,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 0,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region SECTION 1
            data = "Background";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 7,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "This Policy applies as between you, the User of this Web Site and Compare Cloudware Ltd the owner and provider of this Web Site.  This Policy applies to our use of any and all Data collected by us in relation to your use of the Web Site and any Services or Systems therein.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 8,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "1.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 9,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Definitions and Interpretation";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 9,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "In this Policy the following terms shall have the following meanings:";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 10,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Account\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 11,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means collectively the personal information, Payment Information and credentials used by Users to access Material and / or any communications System on the Web Site;";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 11,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Content\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 12,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means any text, graphics, images, audio, video, software, data compilations and any other form of information capable of being stored in a computer that appears on or forms part of this Web Site;";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 12,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Cookie\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 13,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means a small text file placed on your computer by www.comparecloudware.com when you visit certain parts of this Web Site.  This allows us to identify recurring visitors and to analyse their browsing habits within the Web Site.  Where e-commerce facilities are provided, Cookies may be used to store your company, personal and/or payment details for subscription services.  Further details are contained in Clause 10 and Schedule 1 of this Policy;";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 13,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Data\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 14,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means collectively all information that you submit to the Web Site.  This includes, but is not limited to, Account details and information submitted using any of our Services or Systems;";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 14,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Compare Cloudware\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 15,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means ";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 15,
                Indent = 4,
                SectionText1 = data,
                SectionText2 = "www.comparecloudware.com",
                SectionText2IsURL = true,
                SectionText2URL = "www.comparecloudware.com",
                SectionText3 = ", Compare Cloudware or Compare Cloudware Ltd a company incorporated under the laws of England with its registered office address at Shalford Court, 95 Springfield Road, Chelmsford, Essex, CM2 6JL.",
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Service\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 16,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means collectively any online facilities, tools, services or information that Compare Cloudware Ltd makes available through the Web Site either now or in the future;";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 16,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"System\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 17,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means any online communications infrastructure that Compare Cloudware Ltd makes available through the Web Site either now or in the future.  This includes, but is not limited to, web-based email, message boards, live chat facilities and email links;";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 17,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"User\" / \"Users\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 18,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means any third party that accesses the Web Site and is not employed by Compare Cloudware Ltd and acting in the course of their employment; and";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 18,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "\"Web Site\"";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 19,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 4,
                Section = 1,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "means the website that you are currently using (www.comparecloudware.com) and any sub-domains of this site (e.g. subdomain.<<URL>>) unless expressly excluded by their own terms and conditions.";
            tc = new TermCondition
            {
                ParentDisplayID = 9,
                DisplayID = 19,
                Indent = 4,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 1,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region SECTION 2
            data = "2.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 20,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Data Collected";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 20,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Without limitation, any of the following Data may be collected:";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 21,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.1";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 22,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "name;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 22,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.2";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 23,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "date of birth;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 23,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.3";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 24,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "gender;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 24,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.4";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 25,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "job title;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 25,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.5";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 26,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "profession;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 26,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.6";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 27,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "contact information such as email addresses and telephone numbers;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 27,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.7";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 28,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "demographic information such as post code, preferences and interests;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 28,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.8";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 29,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "financial information such as credit / debit card numbers;";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 29,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.9";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 30,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "IP address (automatically collected);";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 30,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.10";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 31,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "web browser type and version (automatically collected);";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 31,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.11";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 32,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "operating system (automatically collected);";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 32,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.12";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 33,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "a list of URLS starting with a referring site, your activity on this Web Site, and the site you exit to (automatically collected); and";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 33,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.13";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 34,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Cookie information (see clause 10 below).";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 34,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "2.14";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 35,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Content relating to the marketing of cloudware services ";
            tc = new TermCondition
            {
                ParentDisplayID = 20,
                DisplayID = 35,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 2,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region SECTION 3
            data = "3.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 36,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Our Use of Data";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 36,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.1";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 37,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Any personal Data you submit will be retained by Compare Cloudware Ltd for as long as you use the Services and Systems provided on the Web Site.  Data that you may submit through any communications System that we may provide may be retained for a longer period of up to 10 years.";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 37,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.2";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 38,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Unless we are obliged or permitted by law to do so, and subject to Clause 4, your Data will not be disclosed to third parties.  This does not include our affiliates and / or other companies within our group.";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 38,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.3";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 39,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "The data we collect is processed for the purposes indicated in our ";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 39,
                Indent = 2,
                SectionText1 = data,
                SectionText2 = "Terms of Use",
                SectionText2IsURL = true,
                SectionText2URL = "TermsOfUsePage",
                SectionText3 = ", including without limitation management of the Web Site and Users, matching Application providers with Users that are willing to learn about products and services, displaying relevant content on our Web Site, contacting Users and sending commercial communications, and such other specific purposes indicated or implicit in each part of the Site.",
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.4";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 40,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "By filling in and sending your data to Compare Cloudware Ltd, you expressly consent to receive communications regarding the subject matter of the Site and other services. These commercial communications, including alerts, notices, newsletters, offers and promotions, will be always sent by Compare Cloudware Ltd, or by Application Providers to whom you have requested your data to be sent in relation to a request, lead or Application";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 40,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.5";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 41,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.5	If you do not wish to receive information form this Web Site and expressly opt out by sending a notification to optout@comparecloudware.com";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 41,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.6";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 42,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "All personal Data is stored securely in accordance with the principles of the Data Protection Act 1998. For more details on security, see clause 9 below.";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 42,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.7";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 43,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Any or all of the above Data may be required by us from time to time in order to provide you with the best possible service and experience when using our Web Site.  Specifically, Data may be used by us for the following reasons:";
            tc = new TermCondition
            {
                ParentDisplayID = 36,
                DisplayID = 43,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.7.1";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 44,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "internal record keeping;";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 44,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.7.2";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 45,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "improvement of our products / services;";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 45,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.7.3";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 46,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "transmission by email of promotional materials that may be of interest to you;";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 46,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "3.7.4";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 47,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "contact for market research purposes which may be done using email, telephone, fax or mail.  Such information may be used to customise or update the Web Site.";
            tc = new TermCondition
            {
                ParentDisplayID = 43,
                DisplayID = 47,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 3,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region SECTION 4
            data = "4.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 48,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 4,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Third Party Web Sites and Services";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 48,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd may, from time to time, employ the services of other parties for dealing with matters that may include, but are not limited to, payment handling, delivery of purchased items, search engine facilities, advertising and marketing.  The providers of such services may have access to certain personal Data provided by Users of this Web Site. Any Data used by such parties is used only to the extent required by them to perform the services that Compare Cloudware Ltd requests.  Any use for other purposes is strictly prohibited.  Furthermore, any Data that is processed by third parties must be processed within the terms of this Policy and in accordance with the Data Protection Act 1998.";
            tc = new TermCondition
            {
                ParentDisplayID = 48,
                DisplayID = 49,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "www.comparecloudware.com contains links to other web Sites whose information practices may be different than ours.  We recommend visitors to consult the respective policies of these third parties for more information on their information practices. Compare  Cloudware Ltd privacy policy does not apply to, and we have no control over the activities or information that is submitted to, nor collected and processed by, these third parties.";
            tc = new TermCondition
            {
                ParentDisplayID = 48,
                DisplayID = 50,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "We may partner with identified third parties however we do not provide any personally identifiable information to these third parties without your consent";
            tc = new TermCondition
            {
                ParentDisplayID = 48,
                DisplayID = 51,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 4,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);


            #endregion

            #region SECTION 5
            data = "5.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 52,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Changes of Business Ownership and Control";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 52,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "5.1";
            tc = new TermCondition
            {
                ParentDisplayID = 52,
                DisplayID = 53,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 5,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd may, from time to time, expand or reduce its business and this may involve the sale of certain divisions or the transfer of control of certain divisions to other parties.  Data provided by Users will, where it is relevant to any division so transferred, be transferred along with that division and the new owner or newly controlling party will, under the terms of this Policy, be permitted to use the Data for the purposes for which it was supplied by you.";
            tc = new TermCondition
            {
                ParentDisplayID = 52,
                DisplayID = 53,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "In the event that any Data submitted by Users will be transferred in such a manner, you will not be contacted in advance and informed of the changes.";
            tc = new TermCondition
            {
                ParentDisplayID = 52,
                DisplayID = 54,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 5,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region SECTION 6
            data = "6.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 55,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Controlling Access to your Data";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 55,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "6.1";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 56,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Wherever you are required to submit Data, you will be given options to restrict our use of that Data.  This may include the following:";
            tc = new TermCondition
            {
                ParentDisplayID = 55,
                DisplayID = 56,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "6.1.1";
            tc = new TermCondition
            {
                ParentDisplayID = 56,
                DisplayID = 57,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "use of Data for direct marketing purposes; and";
            tc = new TermCondition
            {
                ParentDisplayID = 56,
                DisplayID = 57,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "6.1.2";
            tc = new TermCondition
            {
                ParentDisplayID = 56,
                DisplayID = 58,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 6,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "sharing Data with third parties.";
            tc = new TermCondition
            {
                ParentDisplayID = 56,
                DisplayID = 58,
                Indent = 3,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 6,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region SECTION 7
            data = "7.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 59,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Your Right to Withhold Information";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 59,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.1";
            tc = new TermCondition
            {
                ParentDisplayID = 59,
                DisplayID = 60,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You may access certain areas of the Web Site without providing any Data at all.  However, to use all Services and Systems available on the Web Site you may be required to submit Account information or other Data.";
            tc = new TermCondition
            {
                ParentDisplayID = 59,
                DisplayID = 60,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "7.2";
            tc = new TermCondition
            {
                ParentDisplayID = 59,
                DisplayID = 61,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 7,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You may restrict your internet browser’s use of Cookies.  For more information see clause 10.4 below.";
            tc = new TermCondition
            {
                ParentDisplayID = 59,
                DisplayID = 61,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 7,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);
            #endregion

            #region SECTION 8
            data = "8.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 62,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Accessing your own Data";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 62,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "8.1";
            tc = new TermCondition
            {
                ParentDisplayID = 62,
                DisplayID = 63,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You may access your Account at any time to view or amend the Data.  You may need to modify or update your Data if your circumstances change.  Additional Data as to your marketing preferences may also be stored and you may change this at any time.";
            tc = new TermCondition
            {
                ParentDisplayID = 62,
                DisplayID = 63,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "8.2";
            tc = new TermCondition
            {
                ParentDisplayID = 62,
                DisplayID = 64,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 8,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You have the right to ask for a copy of your personal Data on payment of a small fee.";
            tc = new TermCondition
            {
                ParentDisplayID = 62,
                DisplayID = 64,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 8,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region SECTION 9
            data = "9.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 65,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Security";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 65,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "9.1";
            tc = new TermCondition
            {
                ParentDisplayID = 65,
                DisplayID = 66,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 9,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Data security is of great importance to Compare Cloudware Ltd and to protect your Data we have put in place suitable physical, electronic and managerial procedures to safeguard and secure Data collected online.";
            tc = new TermCondition
            {
                ParentDisplayID = 65,
                DisplayID = 66,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 9,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region SECTION 10
            data = "10.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 67,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Cookies";
            tc = new TermCondition
            {
                ParentDisplayID = 1,
                DisplayID = 67,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "10.1";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 68,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = " may set and access Cookies on your computer.  Cookies that may be placed on your computer are detailed in Schedule 1 to this Policy.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 68,
                Indent = 2,
                SectionText1 = "www.comparecloudware.com",
                SectionText1IsURL = true,
                SectionText1URL = "www.comparecloudware.com",
                SectionText2 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "10.2";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 69,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "A Cookie is a small file that resides on your computer’s hard drive and often contains an anonymous unique identifier and is accessible only by the web site that placed it there, not any other sites.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 69,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "10.3";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 70,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You may delete Cookies, however you may lose any information that enables you to access the Web Site more quickly.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 70,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "10.4";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 71,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "You can choose to enable or disable Cookies in your web browser.  By default, your browser will accept Cookies, however this can be altered.  For further details please consult the help menu in your browser.  Disabling Cookies may prevent you from using the full range of Services available on the Web Site.";
            tc = new TermCondition
            {
                ParentDisplayID = 67,
                DisplayID = 71,
                Indent = 2,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 10,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #region SECTION 11
            data = "11.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 72,
                Indent = 0,
                SectionText1 = data,
                ColumnSpan = 1,
                Section = 11,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Changes to this Policy";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 72,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 11,
                IsBold = true,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "Compare Cloudware Ltd reserves the right to change this Privacy Policy as we may deem necessary from time to time or as may be required by law.  Any changes will be immediately posted on the Web Site and you are deemed to have accepted the terms of the Policy on your first use of the Web Site following the alterations.";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 73,
                Indent = 1,
                SectionText1 = data,
                ColumnSpan = maxCols,
                Section = 11,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            data = "If you have any queries on the Terms & Conditions, email ";
            tc = new TermCondition
            {
                ParentDisplayID = 0,
                DisplayID = 74,
                Indent = 1,
                SectionText1 = data,
                SectionText2 = "privacy@comparecloudware.com",
                SectionText2IsMailRef = true,
                SectionText2MailRef = "privacy@comparecloudware.com",
                SectionText3 = "",
                ColumnSpan = maxCols,
                Section = 11,
                TermConditionType = "PRIVACY_POLICY",
                TermConditionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTermCondition(tc);

            #endregion

            #endregion

            return retVal;
        }

        public static byte[] GetImageAsBytes(string outputPath)
        {
            //string outputPath = MPU_FILEPATH + MPU_FILE1;
            //System.Drawing.Image i = System.Drawing.Image.FromFile(outputPath);
            //FileStream fs = new FileStream(outputPath, FileMode.Open,FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //byte[] image = br.ReadBytes((int)fs.Length);
            byte[] image2 = File.ReadAllBytes(outputPath);
            return image2;
        }

    }
}
