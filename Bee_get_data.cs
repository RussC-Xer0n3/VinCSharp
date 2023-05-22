using System;

public class Bee_get_data
{     
    public static object GetBee()
    {

        int f, g, h, i;
        int v = Program.V_qty;
        double vol = Math.Pow(v, 3);
        Object[,,] hive = HiveNest.Hive;
        object bee = null;
        
        for (f = 0; f < (int)vol; f++)
        {
            for (g = 0; g < v; g++)
            {
                for (h = 0; h < v; h++)
                {
                    for (i = 0; i < v; i++)
                    {
                        bee = HiveNest.Cells.TryGetValue(f, out i);
                        Console.WriteLine("Values from Bee_get_data.getBee() {0}" + bee);
                    }
                }
            }
        }
        return bee;
    }
    public static object BeeGetData(int n)
	{
        object[,,] hive = HiveNest.Hive;
        Dictionary<int, int> cells = HiveNest.Cells;
        List<Object> bee = new List<Object>();
        IDictionary<int, Object> bees = new Dictionary<int, Object>();

        object avalue = null;

        for (int e = 0; e < hive.Length; e++) //for the volume size
        {
            if (hive[e, e, e] != null)
            {
                foreach (Object f in cells) //while at cell
                {
                    bee.Add(f); //add the cell to a new dictionary

                    foreach (int g in bee) //if bee is home, if there is data
                    {
                        //get the value as an object
                        bees = new Dictionary<int, Object>(dictionary: (IDictionary<int, object>)GetBee());

                    }
                    Console.WriteLine("New bees IDictionary Object extracted from getBee {0}" + bees);

                    avalue = bees.TryGetValue(n, out object value);

                    Console.WriteLine("Extracted Value is : {0}" + avalue);

                    bee.Remove(f);
                }
            }
            else
            {
                Console.WriteLine("Program Failure at lines 51 onwards: call to Bee_get_data");
                continue;
            }
            
        }
        return avalue;
    }
}
