namespace my_console_demo_6.VideoGame;

public interface ICollidable
{
    void Collide();
}


public class Solid : ICollidable
{
    public void Collide()
    {
        Console.WriteLine("Bang!");
    }
}

public class Liquid : ICollidable
{
    public void Collide()
    {
        Console.WriteLine("Splash!");
    }
}
