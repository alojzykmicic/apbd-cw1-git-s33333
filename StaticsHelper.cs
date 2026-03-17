namespace apbd_cw1_git_s33333;

public class StaticsHelper
{ 
    public static double CalculateAverage(int[] vals)
    {
        if (vals == null || vals.Length == 0) return 0;
        return vals.Average();
    }

    public static int CalculateMax(int[] vals)
    {
        if (vals == null || vals.Length == 0) return 0;
        return vals.Max();
        
    }
}