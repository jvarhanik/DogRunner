using Godot;

public partial class BarrelBehaviour : ScrollMovement
{
	public override void _PhysicsProcess(double delta)
	{
		Move();
	}
	
	private void OnObstacleBodyEntered(Node body)
	{
		if (body.Name == "Player")
		{
			QueueFree();
			GetNode<Signals>("/root/Signals").EmitSignal(nameof(Signals.Killplayer));
		}
	}

	public override void _Ready()
	{
		base._Ready();
		GetNode<Area2D>("Obstacle").BodyEntered += OnObstacleBodyEntered;
	}
}
