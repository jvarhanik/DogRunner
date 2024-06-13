using Godot;
using System;

public partial class MainMenu : Control
{
	private AudioStreamPlayer2D _Music;
	
	public override void _Ready()
	{
		var startGameButton = GetNode<Button>("StartGame");
		startGameButton.Connect("pressed", new Callable(this, nameof(OnStartGamePressed)));
		
		var quitGameButton = GetNode<Button>("QuitGame");
		quitGameButton.Connect("pressed", new Callable(this, nameof(OnQuitGamePressed)));
		
		_Music = GetNode<AudioStreamPlayer2D>("BgMusic");
		_Music.Play();
	}

	private void OnStartGamePressed()
	{
		GetTree().ChangeSceneToFile("res://Game.tscn"); // Uistite sa, že cesta je správna
	}

	private void OnQuitGamePressed()
	{
		GetTree().Quit();
	}
}
