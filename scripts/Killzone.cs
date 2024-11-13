using Godot;
using System;

public partial class Killzone : Area2D
{
    [Export] private Timer _timer;
    private void OnBodyEntered(Node2D body)
    {
        
        //_timer.GetTree().ReloadCurrentScene();
        GD.Print("You died");
        _timer.Start();
        _timer.Timeout += OnTimerTimeOut;
    }
    private void OnTimerTimeOut()
    {   
        //_limit.Timeout -= OnTimerTimeOut;
        GD.Print("Game restarted");
        GetTree().ReloadCurrentScene();
    }
}


//https://docs.godotengine.org/en/stable/getting_started/step_by_step/signals.html