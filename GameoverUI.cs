using Godot;
using System;

public partial class GameoverUI : Control
{
	public override void _Ready()
	{
		var signals = GetNode<Signals>("/root/Signals");
		signals.Connect(nameof(Signals.Killplayer), new Callable(this, nameof(GameOver)));
		
		var button = GetNode<Button>("RestartButton");
		button.Connect("pressed", new Callable(this, nameof(OnButtonPressed)));
		
		var quitButton = GetNode<Button>("QuitButton");
		quitButton.Connect("pressed", new Callable(this, nameof(OnQuitButtonPressed)));
	}

	private void OnButtonPressed()
	{
		GetTree().ReloadCurrentScene();
	}
	
	private void OnQuitButtonPressed()
	{
		GetTree().Quit();
	}

	private void GameOver()
	{
		Show();
	}
}
