using Godot;
using System;

public partial class Signals : Node
{
	[Signal]
	public delegate void KillplayerEventHandler();
	
	[Signal]
	public delegate void RewardplayerEventHandler();
	
	[Signal]
	public delegate void UpdatescoreEventHandler();
}
