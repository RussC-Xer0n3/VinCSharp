using System;

public class RandomWeights
{
    public double[] random_weights()
    {
        Program prog = new Program();
        
        int n = Program.N_qty;
        
        Random random = new System.Random();

        double[] weights = new double[n];

        for (int i = 0; i < n; i++)
        {
            double weight = random.NextDouble();
            weights[i] = weight;
        }

        return weights; 
    }
}
