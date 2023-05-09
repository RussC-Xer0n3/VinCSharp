using System;
using System.Runtime.CompilerServices;

/**
 * Using Cubic logic, assign a proximity based on a radius
 * @author xer0n3 - developing821@outlook.com - R.Clarke
 * @reference School, Oracle Java API and Lewis & Loftus, O'Reilly 'Programming C# 3rd Ed.'
 */
public class Touch
{
    Program v = new Program();
    
    private static double r;
    
    /**
	 * Returns and sets the radius
	 * @return
	 */
    public static double R
    {
        get { return r; }
        set { r = value; }
    }

    /**
     * return the spherical volume of touch zone
     * for each Neuron, permits for a double type.
     * @return
     */
    public static double touch(double r)
    {
       return r * (Math.Pow(Program.V_qty, 3) / 9);
    }


    /**
	 * Creates the volume according to the proximity
	 * called from within permits for Object type.
	 * @return
	 */
    public static Object touch_obj(double r) 
    {
        return Radial_volume.a(touch(r));
    }
}
