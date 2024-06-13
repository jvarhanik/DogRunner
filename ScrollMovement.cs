using Godot;

public partial class ScrollMovement : Node2D
{
	[Export]
	public float ScrollSpeed { get; set; } = 5.0f;

	public override void _Ready()
	{
		// Replace with function body
	}

	public void Move()
	{
		Position = new Vector2(Position.X - ScrollSpeed, Position.Y);
	}
}
