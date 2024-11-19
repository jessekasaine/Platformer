using Godot;

public partial class Coin : Area2D
{
	public override void _Ready()
	{
		GD.Print("Im a coin");
	}

	//Called when a body enters a certain Area 2d
	private void OnBodyEntered(Node2D body)
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
