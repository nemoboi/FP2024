using Godot;
using System;

public partial class Tutorial01 : Node2D
{
	private void _on_retrylevel_pressed(){
		GD.Print("retry Level 01");
		GetTree().ChangeSceneToFile("res://Levels/Tutorial01.tscn");
	}
	private void _on_quitlevel_pressed(){
		GD.Print("back to menu");
		GetTree().ChangeSceneToFile("res://menu/Mainmenu.tscn");
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
