using Godot;

public partial class SlimeEnemy : Node2D
{
    private float _speed = 60f;

    public void _Process(float delta)
    {
        
        var position = new Vector2(Position.X , Position.Y);
        Position = position;
        Position += new Vector2(_speed * delta, 0f);
    }
}
