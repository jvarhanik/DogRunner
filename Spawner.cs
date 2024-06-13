using Godot;
using System;

public partial class Spawner : Node2D
{
	[Export]
	public Godot.Collections.Array<PackedScene> Scenes { get; set; } = new Godot.Collections.Array<PackedScene>();

	private RandomNumberGenerator _randomScene = new RandomNumberGenerator();
	private int _selectedSceneIndex = 0;

	public override void _Ready()
	{
		GetNode<Timer>("Timer").Timeout += OnTimerTimeout;
	}

	private void OnTimerTimeout()
	{
		_randomScene.Randomize();
		_selectedSceneIndex = _randomScene.RandiRange(0, Scenes.Count - 1);
		Node tmp = Scenes[_selectedSceneIndex].Instantiate();
		AddChild(tmp);
	}
}
