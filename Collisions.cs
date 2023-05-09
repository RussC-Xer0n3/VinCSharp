using System;
using System.Data;
using System.Linq.Expressions;

public class Collisions
{
	public static int[,] Collision(int ID)
	{
        /**
         * Designed to make use of our volume and the proximities 
         * for each neuron and establish connections based on collision theory
         * 
         * @author xer0n3 - developing821@outlook.com - R.Clarke
         * @reference H4KR Blunt - https://gamedev.stackexchange.com/questions/16976/sphere-collision-response
         * @TODO IMPROVE
         */
        int x = Program.V_qty;
        int y = Program.V_qty;
        int z = Program.V_qty;

        Dictionary<int, int> cells = new Dictionary<int, int>(dictionary: HiveNest.Cells);

        /**
         * Receives a single ID value to be assessed and all the other
         * IDvalues for collision detection, if there are collisions
         * there are connections and the data is stored according only to
         * how many Neurons there are in the volume.
         * 
         * @param ID
         * @param IDs
         * @return
         */

        Console.WriteLine("Collision detecting...");

        int[,] connections = new int[1980, 1980];

        //get our ID coordinate values
        int queenbee_x = GetX.getx(ID);
        int queenbee_z = GetZ.getz(ID);
        int queenbee_y = GetY.gety(ID);

        Console.WriteLine("xzy coordinates for all IDs :: " + queenbee_x + ", " + queenbee_z + ", " + queenbee_y);

        //get our IDs (ID b) coordinate values [IDs]
        int bee_x = GetX.getx(ID);
        int bee_z = GetZ.getz(ID);
        int bee_y = GetY.gety(ID);

        Console.WriteLine("xzy coordinates ID  :: " + bee_x + ", " + bee_z + ", " + bee_y);
        //set our variables for the entry set from the hash map
        double a = 0;
        double b = 0;
        double c = 0;

        double qa = 0;
        double qb = 0;
        double qc = 0;

        //cycle through and allocate the values for ID
        for (int i = 0; i < cells.Count; i++)
        {
            for (int n = 0; n < 12; n++)
            {
                if (ID == cells.ElementAt(n).Key)
                {
                    a = (double)GetIndex.GetIndexValue(3);
                    b = (double)GetIndex.GetIndexValue(2);
                    c = (double)GetIndex.GetIndexValue(1);
                }

            }
        }

        //cycle through and allocate the values for IDs (ID b)
        for (int i = 0; i < cells.Count; i++)
        {
            if (ID == (int)GetIndex.GetIndexValue(11))
            {
                qa = (double)GetIndex.GetIndexValue(3);
                qb = (double)GetIndex.GetIndexValue(2);
                qc = (double)GetIndex.GetIndexValue(1);
            }
        }

        //make a subtraction of the coordinates
        int e = queenbee_x - bee_x;
        int f = queenbee_y - bee_y;
        int g = queenbee_z - bee_z;

        Console.WriteLine("Coordinate subtraction xzy :: " + e + ", " + f + ", " + g);

        //surmise the radii of each
        double val1 = qa + b;
        double val2 = qb + c;
        double val3 = qc + a;

        Console.WriteLine("Radii surmise ID to IDs :: " + val1 + ", " + val2 + ", " + val3);

        //if the multiples of radii are greater than the sum of coordinates allocate and return the value
        for (int i = 0; i < Program.N_qty; i++)
        {
            if (val1 * val2 * val3 >= (e * e + f * f + g * g))
            {
                connections[i, i] += connections[ID, ID];
            }
        }

        for (int aa = 0; aa < connections.Length; aa++)
        {
            Console.WriteLine("Connection found:: " + connections[aa, aa]);
        }

        return connections;
    }
}