using System;
using System.Collections;
using System.Linq;

/**
 * Using Cubic logic, assign a proximity based on a radius
 * @author xer0n3 - developing821@outlook.com - R.Clarke
 * @reference School, Oracle Java API and Lewis & Loftus, O'Reilly 'Programming C# 3rd Ed.'
 */

class Neuron
{
    public static object Train
    {
        get { return Neuron_cell().ElementAt(0); }
        set { Train = value; }
    }
    public static object Touchr
    {
        get { return Neuron_cell().ElementAt(1); }
    }
    public static object Greenr
    {
        get { return Neuron.Neuron_cell().ElementAt(2); }
    }
    public static object Redr
    {
        get { return Neuron.Neuron_cell().ElementAt(3); }
    }
    public static object Touchs
    {
        get { return Neuron.Neuron_cell().ElementAt(4); }
    }
    public static object Greens
    {
        get { return Neuron.Neuron_cell().ElementAt(5); }
    }
    public static object Reds
    {
        get { return Neuron.Neuron_cell().ElementAt(6); }
    }
    public static object Weights
    {
        get { return Neuron.Neuron_cell().ElementAt(7); }
        set { Weights = value; }
    }
    public static object X
    {
        get { return Neuron.Neuron_cell().ElementAt(8); }
        set { X = value; }
    }
    public static object Z
    {
        get { return Neuron.Neuron_cell().ElementAt(9); }
        set { Z = value; }
    }
    public static object Y
    {
        get { return Neuron.Neuron_cell().ElementAt(10); }
        set { Y = value; }
    }
    public static object Output
    {
        get { return Neuron.Neuron_cell().ElementAt(11); }
        set { Output = value; }
    }

    public static object[] Neuron_cell()
    {
        Object[] neuron = new object[12];
        Touch touch = new Touch();
        Red red = new Red();
        Green green = new Green();
        SurfaceSphere surface = new SurfaceSphere();

        neuron[0] = Training.train(); //0 - Training module or sigmoid etc etc, initially empty method, new class method Added in HiveNest mapping.
        neuron[1] = Touch.touch(Program.Rad); //1 - Mating zone, the quintessential zone of mating, energy transfer, bioelectrical transfer, atomic emf/emp bonds
        neuron[2] = Green.green(Program.Rad); //2 - emf
        neuron[3] = Red.red(Program.Rad); //3 - red zone, widest emf radii
        neuron[4] = SurfaceSphere.surface(Touch.touch(Program.Rad)); //
        neuron[5] = SurfaceSphere.surface(Green.green(Program.Rad)); //
        neuron[6] = SurfaceSphere.surface(Red.red(Program.Rad)); //
        neuron[7] = 0; // weights
        neuron[8] = 0; // x
        neuron[9] = 0; // y
        neuron[10] = 0; // z
        neuron[11] = 0; // key ID

        return neuron;
    }
}