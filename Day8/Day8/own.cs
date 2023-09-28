using System;
using System.Collections.Generic;
using System.Linq;

public static class MyExtensions
{
    public static T First<T>(this IEnumerable<T> source)
    {
        foreach (var item in source)
        {
            return item;
        }

        throw new InvalidOperationException("The source sequence is empty.");
    }

    public static T Last<T>(this IEnumerable<T> source)
    {
        T lastItem = default(T);
        bool found = false;

        foreach (var item in source)
        {
            lastItem = item;
            found = true;
        }

        if (!found)
        {
            throw new InvalidOperationException("The source sequence is empty.");
        }

        return lastItem;
    }

    public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<T> Take<T>(this IEnumerable<T> source, int count)
    {
        int taken = 0;

        foreach (var item in source)
        {
            if (taken >= count)
            {
                yield break;
            }

            yield return item;
            taken++;
        }
    }

    public static IEnumerable<T> OrderBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
    {
        return source.OrderBy(keySelector);
    }

    //public static IEnumerable<T> OrderByDescending<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
    //{
    //    return source.OrderByDescending(keySelector);
    //}

    public static IEnumerable<TResult> Select<T, TResult>(this IEnumerable<T> source, Func<T, TResult> selector)
    {
        foreach (var item in source)
        {
            yield return selector(item);
        }
    }
}