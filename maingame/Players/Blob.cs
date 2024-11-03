using Godot;
using System;

public partial class Blob : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	
	// name delta deltaT because it's the time between the frames
	public override void _PhysicsProcess(double deltaT)
	{
		
		// handle movement of blob
		
		Vector2 velocity = Velocity;

		// add gravity
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)deltaT;
		}

		// handle Jump
		else if (Input.IsActionJustPressed("blob_jump") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
		}

		// get input direction using inputs and handle the movement/deceleration
		// move left and right
		Vector2 direction = Input.GetVector("blob_left", "blob_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
