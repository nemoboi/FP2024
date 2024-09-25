using Godot;
using System;

public partial class menu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_new_game_pressed()
	{
		GetTree().ChangeSceneToFile("res://miau.tscn");
	}
	private void _on_settings_pressed()
	{
		GetTree().ChangeSceneToFile("res://settings.tscn");
	}
	private void _on_saved_games_pressed()
	{
		GetTree().ChangeSceneToFile("res://saved_games.tscn");
	}
	private void _on_quit_pressed()
	{
		GetTree().Quit();
	}
	
	
}








