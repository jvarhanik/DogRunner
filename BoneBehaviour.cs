using Godot;

public partial class BoneBehaviour : ScrollMovement
{
	private AudioStreamPlayer2D _pickupSound;
	
	public override void _PhysicsProcess(double delta)
	{
		Move();
	}
	
	private async void OnPickupBodyEntered(Node body)
	{
		if (body.Name == "Player")
		{
			GetNode<Signals>("/root/Signals").EmitSignal(nameof(Signals.Rewardplayer), 1);
			_pickupSound.Play();
			await ToSignal(_pickupSound, "finished");
			QueueFree();
		}
	}

	public override void _Ready()
	{
		base._Ready();
		 _pickupSound = GetNode<AudioStreamPlayer2D>("PickupSound");
		GetNode<Area2D>("Pickup").BodyEntered += OnPickupBodyEntered;
	}
	
}
