using Godot;
using System;

public partial class Menu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_new_game_pressed() {
		GD.Print("Start new game");
		GetTree().ChangeSceneToFile("res://Levels/Tutorial01.tscn");
	}
	private void _on_saved_games_pressed() {
		GD.Print("Switch to saved games screen");
		// GetTree().ChangeSceneToFile("res://menu/savedgames.tscn");
	}
	private void _on_settings_pressed() {
		GD.Print("Switch to settings screen");
		// GetTree().ChangeSceneToFile("res://menu/settings.tscn");
	}
	private void _on_quit_pressed() {
		GD.Print("Game quit");
		GetTree().Quit();
	}
}
