using Godot;
using System;

public partial class Coin : Area2D
{
	public override void _Ready()
	{
		GD.Print("Im a coin");
	}

	//Called when a body enters a certain Area2d
	private void OnBodyEntered(Godot.Node2D body)
	{
		GD.Print($"+1 for {body.Name}");
	}
}



// Called when the node enters the scene tree for the first time.
// public override void _Ready()
// {
// 	GD.Print("Im a coin");
// }

// // Called every frame. 'delta' is the elapsed time since the previous frame.
// public override void _Process(double delta)
// {
// }
