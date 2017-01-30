using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

namespace PM.Tools //Example of namespaces w/ derive class.
{
	public class PM_CharacterBehavior : MoreMountains.CorgiEngine.CharacterBehavior {

		// associated gameobjects and positions
		protected SpriteFactory.Sprite _sprite;

		public new virtual void UpdateAnimator()
		{
			/// <summary>
			/// This is called at Update() and sets each of the animators parameters to their corresponding State values
			/// </summary>
			/// Check if sprita has animation
			if (_sprite != null) 
			{
				MMAnimator.UpdateAnimatorBool(_animator,"Grounded",_controller.State.IsGrounded); //using MoreMountains.Tools
			}
		}

		protected virtual void Start()
		{
			// we get the sprite
			if (GetComponent<SpriteFactory.Sprite>() != null)
			{
				_sprite = GetComponent<SpriteFactory.Sprite> ();//
			}
			// if the width of the character is positive, then it is facing right.
			_isFacingRight = transform.localScale.x > 0;

			_originalGravity = _controller.Parameters.Gravity;

			// we initialize all the controller's states with their default values.
			BehaviorState.Initialize();
			BehaviorState.NumberOfJumpsLeft=BehaviorParameters.NumberOfJumps;


			BehaviorState.CanJump=true;		
		}

	}
}
