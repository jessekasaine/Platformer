using Godot;

namespace Platformer.scripts;
public partial class Killzone : Area2D
{
    //[Export] private Timer _timer;
    private void OnBodyEntered(Node2D body)
    {

        GD.Print($"{body.Name} died");

        //connects to Timer node
        var timer = GetNode<Timer>("Timer");

        //starts timer when body enters killzone
        timer.Start();

        //Call the OnTimerTimeOut() method after the timer ends
        timer.Timeout += OnTimerTimeOut;
    }
    private void OnTimerTimeOut()
    {   
        //_timer.Timeout -= OnTimerTimeOut;
        GD.Print("Game restarted");
        GetTree().ReloadCurrentScene();
    }
}


//https://docs.godotengine.org/en/stable/getting_started/step_by_step/signals.html