using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;

/**
 * Using Cubic logic, assign a proximity based on a radius
 * @author xer0n3 - developing821@outlook.com - R.Clarke
 * @reference School, Oracle Java API and Lewis & Loftus, O'Reilly 'Programming C# 3rd Ed.', w3s
 */
public class HiveNest
{ 
    public static int v = Program.V_qty;

    private static Dictionary<int, int> cells = new Dictionary<int, int>();
	private static Dictionary<int, Object> bees = new Dictionary<int, Object>();

	private static Object[,,] hive = new Object[v, v, v];
    public static Dictionary<int, Object> Bees
	{
		get { return bees; }
	}
	public static Object[,,] Hive
	{
		get { return hive; }
	}
    public static Dictionary<int, int> Cells
    {
		get { return cells; }
    }
	public Object hivenest()
	{
		int a, b, c;

		int[] x_axis = new int[v];
		int[] z_axis = new int[v];
		int[] y_axis = new int[v];

		for (a = 0; a < y_axis.Length; a++) {
			for (b = 0; b < z_axis.Length; b++) { 
				for (c = 0; c < x_axis.Length; c++)
				{
					hive[a, b, c] = y_axis[c];
				}
			}
		}

		return hive;
	}
    public void bee()
	{
		int d;

		int n = Program.N_qty;

		Random neuron = new Random(n);

		for (d = 0; d < n; d++)
		{
			bees.TryAdd(d, Neuron.Neuron_cell());
		}

		foreach (object i in bees) { Console.WriteLine("Value of Bees Dictionary after adding Neurons " + i); }
	}
    public void populate(Object neuron)
	{
		hivenest();
		bee();

		RandomWeights[] weights = new RandomWeights[Program.N_qty];
		
		int e, f, g, h, i, x, y, z;
		int ID = 0;

		double w = 0.0;
        double vol = Math.Pow(Program.V_qty, 3.0);

        Random index = new Random((int)v);
		Random weight = new Random(Program.N_qty);

		List<int> IDz = new List<int>();

        for (e = 0; e < bees.Count; e++)
		{
			for (int yy = 0; yy < e-1; yy++)
			{
				Object[] neuro = Neuron.Neuron_cell();

				ID = index.Next((int)vol);
				
				if (IDz.Contains(ID)) {
                    ID = index.Next((int)vol);
				} else
				{
					IDz.Add(ID);
                }

                x = GetX.getx(ID);
                y = GetY.gety(ID);
                z = GetZ.getz(ID);

                w = weight.Next();

                neuro.SetValue(Training.train(), 0);
				neuro.SetValue(w, 7);
				neuro.SetValue(x, 8);
				neuro.SetValue(y, 9);
				neuro.SetValue(z, 10);
				neuro.SetValue(ID, 11);

				if (x * y * z == ID)
				{
					hive[x, y, z] = neuro;
				}

				for (int p = 0; p < neuro.Length; p++) { Console.WriteLine(neuro.GetValue(p).ToString()); }
			}
			Console.WriteLine("Identities of the cells............");	
			foreach (int j in IDz) { Console.WriteLine(j); }
		}

		/**
		 * Maps the indices of the hive to the cells dictionary 
		 */

		for (f = 0; f < vol; f++)
		{
			for (g = 0; g < v; g++)
			{
				for (h = 0; h < v; h++)
				{
					for (i = 0; i < v; i++)
					{
						if (ID == g + h + i) { cells.TryAdd(ID, (int)hive[g, h, i]); } else { continue; } //Mapping
                    }
				}
			}
		}

		int n = 11; //returns neuron ID

		foreach (Object o in cells) { Console.WriteLine("Values of the cells are " + o + " and their contents using cells.Values are" + cells.Values); }
        foreach (Object o in cells) { Console.WriteLine("Values of the cells are " + o + " and their contents using Bee_get_data() are" + GetIndex.GetIndexValue(n)); }
    }

}