using System;
using System.Collections.Generic;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        List<int> result = new List<int>();

        if (array[0].Length == 0) { return array[0]; }

        int len = array.GetLength(0) - 1;
        int x, y, count;
        count = 0;
        int border = array.GetLength(0) / 2;

        while (count < border)
        {
            x = y = count;

            // movement to the right or down
            while (x != (len - count))
            {
                if (y >= count && y < (len - count)) { result.Add(array[x][y]); y++; }
                else { result.Add(array[x][y]); x++; }
            }
            // movement to the left or up
            while (x != count)
            {
                if (y > count && y <= (len - count)) { result.Add(array[x][y]); y--; }
                else { result.Add(array[x][y]); x--; }
            }

            count++;
        }

        // adding the central element in case length was not even
        if (array.GetLength(0) % 2 != 0) { result.Add(array[border][border]); }

        return result.ToArray();
    }
}