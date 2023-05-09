using System;

/**
 * Using Cubic logic, assign a proximity based on a radius
 * @author xer0n3 - developing821@outlook.com - R.Clarke
 * @reference School, Oracle Java API and Lewis & Loftus, O'Reilly 'Programming C# 3rd Ed.', w3s
 */
public class GetY
{
    public static int gety(int key)
    {
        double val = Math.Pow(Program.V_qty, 3);
        return key % ((int) val);
    }
    
}
