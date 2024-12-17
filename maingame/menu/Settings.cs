using Godot;
using System;

public partial class Settings : Control
{
	private string _inputAction;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// only start processing inputs when button is pressed
		SetProcessInput(false);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey eventKey)
			if (eventKey.Pressed)
				GetTree().Quit();
		SetProcessInput(false);
	}
	
	// Back to Main Menu
	private void _on_back_pressed() {
		GD.Print("Back to Main Menu");
		GetTree().ChangeSceneToFile("res://menu/Mainmenu.tscn");
	}
	
	// Changing Controls
	
	private void change_event(string ev): {
		GD.Print("Press desired button");
		GetTree().Paused = !GetTree().Paused;
		SetProcessInput(true);
		if (Input.IsAnythingPressed())
		{
			Input.Ge
		}
		InputMap.ActionAddEvent();
		string keycode = OS.GetKeycodeString()
	}

	private void _on_switch_blob_left_pressed() {
		GD.Print("Switch blob left pressed");
		_inputAction = "blob_left";
		SetProcessInput(true);
	}
	
	private void _on_switch_blob_right_pressed() {
		GD.Print("Switch blob right pressed");
		_inputAction = "blob_right";
		SetProcessInput(true);
	}
	
	private void _on_switch_blob_jump_pressed() {
		GD.Print("Switch blob jump pressed");
		_inputAction = "blob_jump";
		SetProcessInput(true);
	}
	
	private void _on_switch_blob_interact_pressed() {
		GD.Print("Switch blob interact pressed");
		_inputAction = "blob_interact";
		SetProcessInput(true);
	}
}
