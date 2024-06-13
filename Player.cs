using Godot;
using System;

public partial class Player : CharacterBody2D
{
	private Vector2 _velocity = Vector2.Zero;

	[Export]
	public float JumpVelocity { get; set; } = 1500.0f;

	[Export]
	public float GravityScale { get; set; } = 20.0f;

	private int _score = 0;

	private bool _canJump = true;

	private AnimatedSprite2D _animation;
	
	private AudioStreamPlayer2D _jumpSound;
	
	private AudioStreamPlayer2D _deathSound;
	
	private AudioStreamPlayer2D _runSound;
	
	private AudioStreamPlayer2D _Music;
	
	private Timer _deathTimer;

	public override void _Ready()
	{
		_animation = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		
		_jumpSound = GetNode<AudioStreamPlayer2D>("JumpSound");
		_deathSound = GetNode<AudioStreamPlayer2D>("DeathSound");
		_runSound = GetNode<AudioStreamPlayer2D>("RunSound");
		
		_deathTimer = new Timer();
		AddChild(_deathTimer);
		_deathTimer.Connect("timeout", new Callable(this, nameof(OnDeathTimerTimeout)));
		
		var signals = GetNode<Signals>("/root/Signals");
		signals.Connect(nameof(Signals.Killplayer), new Callable(this, nameof(KillPlayer)));
		signals.Connect(nameof(Signals.Rewardplayer), new Callable(this, nameof(RewardPlayer)));

		_animation.Play("Run");
		_runSound.Play();
		
		var area2D = GetNode<Area2D>("Area2D");
		area2D.BodyEntered += OnArea2DBodyEntered;
		area2D.BodyExited += OnArea2DBodyExited;
		
		_Music = GetNode<AudioStreamPlayer2D>("BgMusic");
		_Music.Play();
	}

	public override void _PhysicsProcess(double delta)
	{
		_velocity.Y += GravityScale;
		MoveAndCollide(_velocity * (float)delta);
	}

	public override void _Input(InputEvent @event)
	{
		_velocity = Vector2.Zero;
		if (_canJump && @event.IsActionPressed("Jump"))
		{
			_velocity.Y -= JumpVelocity;
			_animation.Play("Jump");
			_jumpSound.Play();
		}
	}

	private void OnArea2DBodyEntered(Node2D body)
	{
		if (body is StaticBody2D)
		{
			_canJump = true;
			_animation.Play("Run");
			_runSound.Play();
		}
	}

	private void OnArea2DBodyExited(Node2D body)
	{
		if (body is StaticBody2D)
		{
			GD.Print("Left");
			_canJump = false;
		}
	}

	private void KillPlayer()
	{
		_deathSound.Play();
		_deathTimer.Start(0.2);
	}
	
	private void OnDeathTimerTimeout()
	{
		QueueFree();
	}
	
	private void RewardPlayer(int scoreToAdd)
	{
		_score += scoreToAdd;
		GD.Print(_score.ToString());
		
		var signals = GetNode<Signals>("/root/Signals");
		signals.EmitSignal(nameof(Signals.Updatescore), _score);
	}
}
