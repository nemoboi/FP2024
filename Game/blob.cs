using Godot;
using System;

public partial class blob : Godot.Sprite2D
{
	public float check_mobility() 
	{
		// later when there's stuff, we can slow or stop movement this way
		return 1;
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float AMOUNT = 1.5f;
		
		if(Input.IsKeyPressed(Key.W)){
			this.Position += new Vector2(0,-AMOUNT) * check_mobility();
		}
		if(Input.IsKeyPressed(Key.S)){
			this.Position += new Vector2(0,AMOUNT) * check_mobility();
		}
		
		if(Input.IsKeyPressed(Key.A)){
			this.Position += new Vector2(-AMOUNT,0) * check_mobility();
		}
		if(Input.IsKeyPressed(Key.D)){
			this.Position += new Vector2(AMOUNT,0) * check_mobility();
		}
	}
}
