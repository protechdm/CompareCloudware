namespace CompareCloudware.Web.FluentSecurity
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public abstract class Builder<T> : ICollection<T>, IEnumerable<T>, IEnumerable where T: class
    {
        protected readonly ICollection<T> _itemValues;

        protected Builder()
        {
            this._itemValues = new Collection<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this._itemValues.GetEnumerator();
        }

        void ICollection<T>.Add(T itemValue)
        {
            this._itemValues.Add(itemValue);
        }

        void ICollection<T>.Clear()
        {
            this._itemValues.Clear();
        }

        bool ICollection<T>.Contains(T itemValue)
        {
            return this._itemValues.Contains(itemValue);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            this._itemValues.CopyTo(array, arrayIndex);
        }

        bool ICollection<T>.Remove(T itemValue)
        {
            return this._itemValues.Remove(itemValue);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        int ICollection<T>.Count
        {
            get
            {
                return this._itemValues.Count;
            }
        }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return false;
            }
        }
    }
}

