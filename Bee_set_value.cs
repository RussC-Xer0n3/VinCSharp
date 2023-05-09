using System;

public class Bee_set_value
{
	public Bee_set_value(int index, object val)
	{
        Object[] neuro = new object[Neuron.Neuron_cell().Length];
        HiveNest Bees = new HiveNest();
        List<Object> beelist = new List<object>();

        for (int e = 0; e < beelist.Count; e++)
        {
            for (int yy = 0; yy < e; yy++)
            {
                for (int xx = 0; xx < neuro.Length; xx++)
                {
                    while (beelist.Contains(xx))
                    {
                        neuro[xx] = beelist.ElementAt(xx);
                    } 
                }

                neuro[index] = val;
            }
            
            beelist[e] = neuro;
        }
    }
}
