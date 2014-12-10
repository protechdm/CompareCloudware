using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using PagedList;

namespace CompareCloudware.Web.Models
{

    public class CustomPagedList<T> : BaseModel, IPagedList
    {
        public CustomPagedList()
        {
        }

        public CustomPagedList(ICustomSession session)
        {
            base.CustomSession = session;
            //PagedList = new PagedList.PagedList<T>();
        }

        public PagedList<T> PagedList { get; set; }


        public int FirstItemOnPage
        {
            get { return PagedList.FirstItemOnPage; }
        }

        public bool HasNextPage
        {
            get { return PagedList.HasNextPage; }
        }

        public bool HasPreviousPage
        {
            get { return PagedList.HasPreviousPage; }
        }

        public bool IsFirstPage
        {
            get { return PagedList.IsFirstPage; }
        }

        public bool IsLastPage
        {
            get { return PagedList.IsLastPage; }
        }

        public int LastItemOnPage
        {
            get { return PagedList.LastItemOnPage; }
        }

        public int PageCount
        {
            get { return PagedList.PageCount; }
        }

        public int PageNumber
        {
            get { return PagedList.PageNumber; }
        }

        public int PageSize
        {
            get { return PagedList.PageSize; }
        }

        public int TotalItemCount
        {
            get { return PagedList.TotalItemCount; }
        }
    }
}

