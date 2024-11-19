using Godot;

public partial class SlimeEnemy : Node2D
{
    private const int Speed = 60;

    private void _Process(float delta)
    {
        var position = new Vector2(Position.X * Speed * delta , Position.Y);
        Position = position;
    }
}
