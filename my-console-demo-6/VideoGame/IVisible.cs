namespace my_console_demo_6.VideoGame;

public interface IVisible
{
   void Paint();
}

public class Visible : IVisible
{
    public void Paint()
    {
        Console.WriteLine("I WIll Appear on the screen");
    }
}

public class Invisible : IVisible
{
    public void Paint()
    {
        Console.WriteLine("I Will Not Appear on the screen");
    }
}        
