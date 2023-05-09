using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

/**
 * Using Cubic logic, assign a proximity based on a radius
 * @author xer0n3 - developing821@outlook.com - R.Clarke
 * @reference School, Oracle Java API and Lewis & Loftus, O'Reilly 'Programming C# 3rd Ed.'
 */

class Program {

    private static int v_qty = 0; //volume quantity
    private static int n_qty = 0; //neuron quatity
    private static int t_qty = 0; //total times to run the training (epochs)
    private static double rad = 0; //radius per neuron
    public static int V_qty
    {
        get { return v_qty; }
        set { v_qty = value; }
    }
    public static int N_qty
    {
        get { return n_qty; }
        set { n_qty = value; }
    }
    public static int T_qty
    {
        get { return t_qty; }
        set { t_qty = value; }
    }

    public static double Rad
    {
        get { return rad; }
        set { rad = value; }
    }
    public static void Main(String[] args)
    {
        v_qty = 4;
        n_qty = 32;
        t_qty = 10;
        rad = 1.0;

        Neuron neurons = new Neuron();

        //call hash mapping
        HiveNest hive = new HiveNest();

        //populate the volume
        hive.populate(neurons);

        //call training insertion
        Bee_Learning bee = new Bee_Learning();
        bee.bee_learning();

        foreach (Object o in HiveNest.Hive) { Console.WriteLine(GetIndex.GetIndexValue(11)); }

        //build the neural net
        Collisions collisions = new Collisions();
        for (int c = 0; c < HiveNest.Cells.Count; c++)
        {
            Collisions.Collision(c);
        }


        //insert data into training???


        //output results
    }

}
