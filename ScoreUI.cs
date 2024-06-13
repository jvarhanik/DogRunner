using Godot;
using System;

public partial class ScoreUI : RichTextLabel
{
	public override void _Ready()
	{
		var signals = GetNode<Signals>("/root/Signals");
		signals.Connect(nameof(Signals.Updatescore), new Callable(this, nameof(UpdateScore)));
	}

	private void UpdateScore(int score)
	{
		Text = score.ToString();
	}
}
