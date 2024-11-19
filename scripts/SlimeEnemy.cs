using Godot;

public partial class SlimeEnemy : Node2D
{
    private float _speed = 60f;

    public override void _Process(double delta)
    {
        var position = new Vector2(Position.X, Position.Y);
        //position.X += (float)(_speed * delta);
        position += new Vector2((float)(_speed * delta), 0f);
        Position = position;
    }
}
