using System;

public class Bee_Learning
{
    public void bee_learning()
	{
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
                    bee.ElementAt(0);
                    HiveNest.Bees.GetValueOrDefault(0);
                }
                else
                {
                    Console.WriteLine("Program Failure at lines 5 onwards: call to training");
                }
            }
        }
    }
}
