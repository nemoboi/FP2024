using Godot;
using System;

public partial class Blobb : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	private AnimatedSprite2D _animatedSprite;
	
	public override void _Ready(){
		_animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}
	
	// name delta deltaT because it's the time between the frames
	public override void _PhysicsProcess(double deltaT)
{
		
		// handle movement of blobb
		
		Vector2 velocity = Velocity;

		// add gravity
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)deltaT;
		}

		// handle Jump
		else if (Input.IsActionJustPressed("blobb_jump") && IsOnFloor())
		{
			_animatedSprite.Play("jump");
			velocity.Y = JumpVelocity;

		} else {
			_animatedSprite.Stop();
		}

		// get input direction using inputs and handle the movement/deceleration
		// move left and right
		Vector2 direction = Input.GetVector("blobb_left", "blobb_right", "ui_up", "ui_down");
		
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
