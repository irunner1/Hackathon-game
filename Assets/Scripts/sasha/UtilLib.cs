using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilLib
{
    public static int GetItemCount<T>(this List<T> source, T item)
    {
        int count = 0;
        source.ForEach((e) =>
        {
            if (e.Equals(item))
                count++;
        });
        return count;
    }
}
