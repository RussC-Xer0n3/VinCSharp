using System;

/**
 * Using Cubic logic, assign a proximity based on a radius
 * @author xer0n3 - developing821@outlook.com - R.Clarke
 * @reference School, Oracle Java API and Lewis & Loftus, O'Reilly 'Programming C# 3rd Ed.', w3s
 */
public class GetX
{
    /**
	 * Perform a modulus of the derivative of the volume
	 * to get X value
	 * 
	 * @param key
	 * @return
	 */
    public static int getx(int key)
    {
        return key % Program.V_qty;
    }
}
