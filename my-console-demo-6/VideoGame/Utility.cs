namespace my_console_demo_6.VideoGame;

public static class Utility
{
    public static T FindMinimum<T>(T a, T b) where T: IComparable<T>
    {
        var z = a.CompareTo(b);

        if(a.CompareTo(b) < 0)
        {
            return a;
        }
        return b;
    }
}
