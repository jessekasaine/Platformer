using Godot;

namespace Platformer.scripts;
public partial class Player : CharacterBody2D
{
	private readonly float _speed = 130.0f;
	private readonly float _jumpVelocity = -300.0f;

	public override void _Ready()
	{
		GD.Print("Im a player");
	}
	public override void _PhysicsProcess(double delta)
	{
		var spriteDirection = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}

		// Handle Jump.
		if (Input.IsActionJustPressed("jump") && IsOnFloor())
		{
			velocity.Y = _jumpVelocity;
		}

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("moveLeft", "moveRight", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * _speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, _speed);
		}

		if (direction > Vector2.Zero)
		{
			spriteDirection.FlipH = false;
		}

		if (direction < Vector2.Zero)
		{
			spriteDirection.FlipH = true;
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}