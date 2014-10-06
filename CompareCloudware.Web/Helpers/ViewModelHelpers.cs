namespace CompareCloudware.Web.Helpers
{
    using CompareCloudware.Domain.Models;
    //using CompareCloudware.Web.App_LocalResources;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Resources;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Web.Mvc;

    public static class ViewModelHelpers
    {
        public const string FORENAME_ERROR_MESSAGE = "Please enter your name";
        public const string SURNAME_ERROR_MESSAGE = "Please enter your surname";
        public const string EMAIL_ERROR_MESSAGE = "Please enter your Email address";

        public static MvcHtmlString DropDownListForCulture<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, IList<Category> categories)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<select data-val=\"true+\" data-val-required=\"The Reason Code field is required.\" id=\"ReasonCode\" name=\"ReasonCode\">", new object[0]);
            ModelMetadata metaData = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
            IEnumerable<SelectListItem> names = selectList;
            SelectListItem selectedValue = (from x in names
                where x.Selected
                select x).FirstOrDefault<SelectListItem>();
            foreach (Category name in categories)
            {
                string item3;
                string selectValue = name.CategoryID.ToString();
                string selectDisplayValue = name.CategoryName;
                string language = "EN-US";
                if (selectedValue.Value == selectValue)
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\"selected=\"selected\">" + selectDisplayValue + "</option>";
                }
                else
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\">" + selectDisplayValue + "</option>";
                }
                sb.AppendFormat(item3, new object[0]);
            }
            sb.AppendFormat("</select>", new object[0]);
            ParameterExpression field = expression.Parameters[0];
            Type generictype = field.GetType();
            string key = field.Name;
            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString DropDownListForCulture2<TModel, TProperty, TItems>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, IList<TItems> modelItems)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<select data-val=\"true+\" data-val-required=\"The Reason Code field is required.\" id=\"ReasonCode\" name=\"ReasonCode\">", new object[0]);
            ModelMetadata metaData = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
            MultiSelectList names = selectList as SelectList;
            SelectListItem selectedValue = (from x in names
                where x.Selected
                select x).FirstOrDefault<SelectListItem>();
            foreach (SelectListItem name in names)
            {
                string item3;
                string selectValue = "name.CategoryID.ToString()";
                selectValue = name.Value;
                string selectDisplayValue = "name.CategoryName";
                selectDisplayValue = name.Text;
                string language = "EN-US";
                if (selectedValue.Value == selectValue)
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\"selected=\"selected\">" + selectDisplayValue + "</option>";
                }
                else
                {
                    item3 = "<option value=\"" + selectValue + "\" culture=\"" + language + "\">" + selectDisplayValue + "</option>";
                }
                sb.AppendFormat(item3, new object[0]);
            }
            sb.AppendFormat("</select>", new object[0]);
            ParameterExpression field = expression.Parameters[0];
            Type generictype = field.GetType();
            string key = field.Name;
            return MvcHtmlString.Create(sb.ToString());
        }

        //public static MvcHtmlString LabelForCulture<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        //{
        //    string key;
        //    string threadCulture = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        //    string regionCulture = RegionInfo.CurrentRegion.TwoLetterISORegionName;
        //    string culture = Thread.CurrentThread.CurrentUICulture.IetfLanguageTag;
        //    culture = culture.Substring(culture.LastIndexOf("-") + 1);
        //    ResourceManager resman = null;
        //    string CS$4$0001 = culture.ToUpper();
        //    if (CS$4$0001 != null)
        //    {
        //        if (!(CS$4$0001 == "NO"))
        //        {
        //            if (CS$4$0001 == "NB")
        //            {
        //                resman = new ResourceManager(typeof(ENGLISH));
        //                goto Label_0104;
        //            }
        //            if (CS$4$0001 == "SE")
        //            {
        //                resman = new ResourceManager(typeof(ENGLISH));
        //                goto Label_0104;
        //            }
        //            if (CS$4$0001 == "DK")
        //            {
        //                resman = new ResourceManager(typeof(ENGLISH));
        //                goto Label_0104;
        //            }
        //            if (CS$4$0001 == "US")
        //            {
        //                resman = new ResourceManager(typeof(ENGLISH));
        //                goto Label_0104;
        //            }
        //        }
        //        else
        //        {
        //            resman = new ResourceManager(typeof(ENGLISH));
        //            goto Label_0104;
        //        }
        //    }
        //    throw new Exception("Could not establish culture: " + culture);
        //Label_0104:
        //    key = (expression.Body as MemberExpression).Member.Name.Trim().ToUpperInvariant();
        //    string strLabel = resman.GetString(key);
        //    return MvcHtmlString.Create("<label for=\"DOMESTIC_" + key + "\">" + strLabel + "</label>");
        //}
    }
}

