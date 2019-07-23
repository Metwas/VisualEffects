using System.Collections.Generic;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Handles the execution of a set of registered <see cref="AnimationBase"/> objects in order
	/// </summary>
	public sealed class Storyboard
	{
		#region Constructors

		/// <summary>
		/// Default constructor
		/// </summary>
		public Storyboard()
		{
			this.Animations = new Queue<AnimationBase>();
		}

		#endregion

		/// <summary>
		/// Stores a first-in first-out collection of <see cref="AnimationBase"/> objects
		/// </summary>
		public Queue<AnimationBase> Animations { get; }

		/// <summary>
		/// The current animation in the queue [<see cref="Animations"/>]
		/// </summary>
		public AnimationBase CurrentAnimation
		{
			get
			{
				return this.Animations.Peek();
			}
		}

		#region Functions



		#endregion
	}
}
