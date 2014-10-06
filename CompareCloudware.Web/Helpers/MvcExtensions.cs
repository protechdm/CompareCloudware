using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using CompareCloudware.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using CompareCloudware.Web.Models;

namespace CompareCloudware.Web.Helpers
{
    public static class MvcExtensions
    {
        public static string GetControllerName(this Type controllerType)
        {
            return controllerType.Name.Replace("Controller", string.Empty);
        }

        public static string GetFullControllerName(this Type controllerType)
        {
            return controllerType.FullName;
        }

        public static string GetActionName(this LambdaExpression actionExpression)
        {
            return ((MethodCallExpression)actionExpression.Body).Method.Name;
        }

        public static MvcHtmlString DisplayForExtended<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName)
        {
            var x = expression.CanReduce;
            return System.Web.Mvc.Html.DisplayExtensions.DisplayFor<TModel, TValue>(html, expression, templateName);
            //return null;
        }

        public static IEnumerable<CoordinateValue<T>> AsEnumerable<T>(this T[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    yield return new CoordinateValue<T>() { Value = arr[i, j], X = i, Y = j };
                    //string x = "";
                }
                //string y = "";
            }
        }

        public static IEnumerable<SearchFilterModelOneColumn> ClearValues(this IEnumerable<SearchFilterModelOneColumn> input)
        {
            if (input != null)
            {
                return (from x in input select new SearchFilterModelOneColumn { Category = x.Category, Col1SearchFilterName = x.Col1SearchFilterName, Col1SearchFilterType = x.Col1SearchFilterType, Col1Selected = false, CustomSession = x.CustomSession, SearchFilterID = x.SearchFilterID });
            }
            else
            {
                return input;
            }
        }

    //    public static IEnumerable<TSource> WhereExtended<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, int rowNumber)
    //where TSource : SearchFeature
    //    {
    //        IEnumerable<SearchFeature> x = System.Linq.Enumerable.Where<TSource>(source, predicate);
    //        int i = 0;
    //        foreach (SearchFeature sf in x)
    //        {
    //            sf.SearchFeatureRowNumber = i;
    //            i++;
    //        }
    //        return (IEnumerable<TSource>)x;
    //    }

        //public static IEnumerable<CloudApplicationModelAlternative> ConstructCloudApplicationModelAlternatives(this CloudApplication alternative)
        public static CloudApplicationModelAlternative ConstructCloudApplicationModelAlternatives(this CloudApplication alternative, ICustomSession customSession)
        {
            //yield 
            return new CloudApplicationModelAlternative()
            {
                Brand = alternative.Brand,
                CloudApplicationID = alternative.CloudApplicationID,
                CloudApplicationLogo = alternative.CloudApplicationLogo,
                CompanyURL = alternative.CompanyURL,
                //CustomSession = this.CustomSession,
                Description = alternative.Description,
                ServiceName = alternative.ServiceName,
                Title = alternative.Title,
                Vendor = new VendorModel()
                {
                    //CustomSession = this.CustomSession,
                    VendorID = alternative.Vendor.VendorID,
                    //VendorLogo = alternative.Vendor.VendorLogo,
                    VendorLogo = alternative.Vendor.VendorLogo != null ? alternative.Vendor.VendorLogo.Logo : null,
                    VendorLogoFileName = alternative.Vendor.VendorLogoFileName,
                    VendorLogoFullURL = alternative.Vendor.VendorLogoFullURL,
                    VendorName = alternative.Vendor.VendorName,
                },
                CustomSession = customSession,
                CloudApplicationCategoryTag = alternative.CloudApplicationCategoryTag.TagName,
                CloudApplicationShopTag = alternative.CloudApplicationShopTag.TagName,
            };
        }
    }

    public class CoordinateValue<T>
    {
        public T Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    //public static class NewLabelExtensions
    //{
    //    public static MvcHtmlString LabelFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object htmlAttributes)
    //    {
    //        return LabelFor(html, expression, new System.Web.Routing.RouteValueDictionary(htmlAttributes));
    //    }
    //    public static MvcHtmlString LabelFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, IDictionary<string, object> htmlAttributes)
    //    {
    //        ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
    //        string htmlFieldName = ExpressionHelper.GetExpressionText(expression);
    //        string labelText = metadata.DisplayName ?? metadata.PropertyName ?? htmlFieldName.Split('.').Last();
    //        if (String.IsNullOrEmpty(labelText))
    //        {
    //            return MvcHtmlString.Empty;
    //        }

    //        TagBuilder tag = new TagBuilder("label");
    //        tag.MergeAttributes(htmlAttributes);
    //        tag.Attributes.Add("for", html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(htmlFieldName));
    //        tag.SetInnerText(labelText);
    //        return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
    //    }
    //}


}