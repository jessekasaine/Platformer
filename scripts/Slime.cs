using Godot;

public partial class Slime : CharacterBody2D
{
	private float _speed = 60f;
	int _direction = 1;

	public override void _Process(double delta)
	{
		var rayCastRight = GetNode<RayCast2D>("RayCastRight");
		var rayCastLeft = GetNode<RayCast2D>("RayCastLeft");

		var spriteDirection = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		if (rayCastRight.IsColliding())
		{
			_direction = -1;
			spriteDirection.FlipH = !spriteDirection.FlipH;
		}
		
		if (rayCastLeft.IsColliding())
		{
			_direction = 1;
			spriteDirection.FlipH = !spriteDirection.FlipH;

		}
		
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}
		Velocity = velocity;

		
		
		var position = new Vector2(Position.X, Position.Y);
		position.X += (float)(_direction * _speed * delta);
		//position += new Vector2((float)(Speed * delta), 0f);
		Position = position;
		
		MoveAndSlide();
	}
}