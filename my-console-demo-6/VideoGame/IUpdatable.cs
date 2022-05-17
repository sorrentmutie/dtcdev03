namespace my_console_demo_6.VideoGame;

public interface IUpdatable
{
    void Update();
}


public class Movable : IUpdatable
{
    public void Update()
    {
        Console.WriteLine("I am moving forward");
    }
}

public class Fixed : IUpdatable
{
    public void Update()
    {
        Console.WriteLine("I stand still");
    }
}