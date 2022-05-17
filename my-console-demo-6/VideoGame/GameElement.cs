namespace my_console_demo_6.VideoGame;

public class ElementA : GameElement
{
    public ElementA(ICollidable collidable, IUpdatable updatable, IVisible visible) : base(collidable, updatable, visible)
    {
    }
}

public abstract class GameElement : ICollidable, IUpdatable, IVisible
{
    private readonly ICollidable collidable;
    private readonly IUpdatable updatable;
    private readonly IVisible visible;

   


    public GameElement(ICollidable collidable, IUpdatable updatable, IVisible visible)
    {
        this.collidable = collidable;
        this.updatable = updatable;
        this.visible = visible;
    }

    public void Collide()
    {
        collidable.Collide();
    }

    public void Paint()
    {
        visible.Paint();    
    }

    public void Update()
    {
        updatable.Update();
    }
}
