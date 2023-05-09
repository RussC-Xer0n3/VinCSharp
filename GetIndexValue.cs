using System;

public class GetIndex
{
    public static object GetIndexValue(int n)
    {
        Dictionary<int, int> cells = HiveNest.Cells;
        List<Object> bee = new List<Object>();

        object avalue = null;

        for (int i = 0; i < cells.Count; i++) {
            if (i == cells.ElementAt(n).Key)
            {
                bee.Add(cells.ElementAt(n));

                while (bee.ElementAt(n) != null) {
                    if (bee.Contains(n)) {
                        avalue = bee.ElementAtOrDefault(n);
                        Console.WriteLine("Value extracted from GetIndexValue {0} expecting value from index {1}" + avalue, n);
                    }
                    else
                    {
                        Console.WriteLine("Issues with extracting data {0}" + avalue); }
                }
                bee.Clear();
            }
        }
            
        return avalue;
    }
}
