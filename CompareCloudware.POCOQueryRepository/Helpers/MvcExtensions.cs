using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Helpers
{
    public static class MvcExtensions
    {
        public static IEnumerable<TSource> WhereExtended<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    where TSource : SearchFilterTwoColumn
        {
            IEnumerable<SearchFilterTwoColumn> x = System.Linq.Enumerable.Where<TSource>(source, predicate);
            int i = 0;
            foreach (SearchFilterTwoColumn f in x)
            {
                f.SearchFilterRowNumberCol1 = i;
                i++;
            }
            return (IEnumerable<TSource>)x;
            return null;
        }

        //
        // Summary:
        //     Creates a System.Collections.Generic.List<T> from an System.Collections.Generic.IEnumerable<T>.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable<T> to create a System.Collections.Generic.List<T>
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.List<T> that contains elements from the input
        //     sequence.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        public static SearchFilterOneColumn[,] ToListExtended<TSource1, TSource2>(this List<TSource1> source, List<TSource2> sourceToAppend)
            where TSource1 : SearchFilterOneColumn
            where TSource2 : SearchFilterOneColumn
        {
            //IEnumerable<Feature> x = System.Linq.Enumerable.Where<TSource>(source, predicate);
            int i = 0;
            SearchFilterOneColumn[,] twocols = new SearchFilterOneColumn[System.Math.Max(source.Count, sourceToAppend.Count), 2];

            foreach (SearchFilterOneColumn f in source)
            {
                twocols[i, 0] = f;
                twocols[1, 1] = sourceToAppend[i];
                //    f.FeatureRowNumber = i;
                i++;
            }
            return twocols;
            //"(List<TSource>)source";


            //int index = source.Select((item, i) => new { Item = item, Index = i })
            //    .First(x => x.Item == search).Index;

            //// or
            //var tagged = list.Select((item, i) => new { Item = item, Index = i });
            //int index = (from pair in tagged
            //             where pair.Item == search
            //             select pair.Index).First();

        }


        //
        // Summary:
        //     Projects each element of a sequence into a new form by incorporating the
        //     element's index.
        //
        // Parameters:
        //   source:
        //     A sequence of values to invoke a transform function on.
        //
        //   selector:
        //     A transform function to apply to each source element; the second parameter
        //     of the function represents the index of the source element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by selector.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable<T> whose elements are the result
        //     of invoking the transform function on each element of source.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        public static IEnumerable<SearchFilterOneColumn> SelectExtended(this IEnumerable<SearchFilterOneColumn> source, Func<IEnumerable<SearchFilterOneColumn>, int, IEnumerable<SearchFilterOneColumn>> selector)
        {
            //IEnumerable<Feature> x = System.Linq.Enumerable.Where<TSource>(source, predicate);
            int i = 0;

            //foreach (Feature f in source)
            //{
            //    f.FeatureRowNumber = i;
            //    i++;
            //}
            //return (List<TSource>)source;
            return null;



        }

    }

    public delegate TResult2 Func<in T1, in T2, in T3, out TResult2>(T1 arg1, T2 arg2, T3 arg3);

    public class TagResultComparer : EqualityComparer<TagResult>
    {
        public override bool Equals(TagResult x, TagResult y)
        {
            return x.CloudApplication.CloudApplicationID == y.CloudApplication.CloudApplicationID;
        }

        public override int GetHashCode(TagResult obj)
        {
            return obj.CloudApplication.CloudApplicationID.GetHashCode();
        }
    } 
   

}