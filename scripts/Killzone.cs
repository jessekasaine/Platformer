using Godot;
using System;

public partial class Killzone : Area2D
{
    private Timer _timer;
    private void OnBodyEntered(Node2D body)
    {
        GD.Print("You died");
        GetTree().ReloadCurrentScene();
    }
}
