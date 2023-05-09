using System;

public class Get_Index
{
	public Get_Index()
	{
        Dictionary<int, int> bees = new Dictionary<int, int>(dictionary: (IDictionary<int, int>)HiveNest.Bees);
        Dictionary<int, int> cells = new Dictionary<int, int>(dictionary: HiveNest.Cells);

        for (int e = 0; e < HiveNest.Cells.Count; e++) //for the cells in the hive
        {
            for (int yy = 0; yy < e; yy++) //while at cell
            {

                Object[] bee = new object[HiveNest.Bees.Count];
                
                if (HiveNest.Cells.TryGetValue(yy, out yy)) //if bee is home
                {
                    object n = HiveNest.Cells.TryGetValue(yy, out yy); //get the values

                    for (int b = 0; b < bee.Length; b++) // for the temporary storage
                    {
                        bee[b] = n; //copy data to noob
                    }

                    //Call method?????
                    bee.ElementAt(yy);
                    Console.WriteLine(HiveNest.Bees.GetValueOrDefault(yy));
                }
                else
                {
                    Console.WriteLine("Program Failure at lines 51 onwards: call to Bee_get_data");
                }
            }
        }
    }
}
