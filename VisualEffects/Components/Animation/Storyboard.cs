using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Handles the execution of a set of registered <see cref="AnimationBase"/> objects
	/// </summary>
	public sealed class Storyboard
	{
		#region Constructors

		/// <summary>
		/// Default constructor
		/// </summary>
		public Storyboard()
		{
			this.Animations = new List<AnimationStoryModel>();
		}

		#endregion

		/// <summary>
		/// Represents the total amount of animations stored
		/// </summary>
		private int _count = 0;

		/// <summary>
		/// Stores <see cref="List{T}"/> of <see cref="AnimationBase"/>
		/// </summary>
		private List<AnimationStoryModel> Animations { get; }

		#region Functions

		/// <summary>
		/// Registers a provided <see cref="StructAnimationBase{T}"/> and the associated <see cref="{T}"/> value
		/// </summary>
		/// <param name="animation">An <see cref="AnimationBase"/></param>
		/// <param name="value">A reference to a value type which will change during the animation progress</param>
		/// param name="start">The starting point in milliseconds</param>
		public void Add<T>(StructAnimationBase<T> animation,ref T value, double startTime = 0.0) where T : struct
		{
			try
			{
				int id = new Random().Next(_count, _count * 2);

				AnimationStoryModel animationModel = this.GetAnimationById(id);
				while (animationModel != null)
				{
					id = new Random().Next(_count, _count * 2);
					animationModel = this.GetAnimationById(id);
				}

				AnimationStoryModel animationStoryModel = new AnimationStoryModel(animation, startTime);
				this.Animations.Add(animationStoryModel);
				this.Animations.Sort();
				_count++;
			}
			catch (Exception exception)
			{
				Debug.WriteLine(exception.Message);
			}
		}

		/// <summary>
		/// Registers a provided <see cref="AnimationBase"/> with an optional start time 
		/// </summary>
		/// <param name="animation">An <see cref="AnimationBase"/></param>
		public void Remove(int id)
		{
			try
			{
				AnimationStoryModel animationStoryModel = this.GetAnimationById(id);

				if (animationStoryModel != null)
				{
					this.Animations.Remove(animationStoryModel);
					this.Animations.Sort();
					_count--;
				}
			}
			catch (Exception exception)
			{
				Debug.WriteLine(exception.Message);
			}
		}

		/// <summary>
		/// Attempts to get an animation by the <see cref="AnimationStoryModel.UID"/> field
		/// </summary>
		/// <param name="id">The id to match against</param>
		/// <returns>A <see cref="AnimationStoryModel"/> stored in the <see cref="Animations"/> collection</returns>
		public AnimationStoryModel GetAnimationById(int id)
		{
			return this.Animations.Find(x => x.UID == id);
		}

		#endregion
	}

	/// <summary>
	/// Used within a <see cref="Storyboard"/> to reference a <see cref="AnimationBase"/> and the start trigger time
	/// </summary>
	public class AnimationStoryModel : IComparable, IComparable<double>
	{
		#region Constructors

		/// <summary>
		/// Default contructor
		/// </summary>
		/// <param name="animation">An <see cref="AnimationBase"/></param>
		/// <param name="start">The starting point in milliseconds</param>
		public AnimationStoryModel(AnimationBase animation, double start = 0.0)
		{
			if (animation == null)
			{
				throw new ArgumentNullException("Provided animation was null!");
			}

			this.Animation = animation;
			this.StartTime = start;
		}

		#endregion

		/// <summary>
		/// The unique id for this animation
		/// </summary>
		public int UID { get; }

		/// <summary>
		/// The main animation
		/// </summary>
		public AnimationBase Animation { get; set; }

		/// <summary>
		/// A trigger point for when this animation should begin, in milliseconds
		/// </summary>
		public double StartTime { get; set; }

		#region Functions

		/// <summary>
		/// Compares the other <see cref="AnimationStoryModel.StartTime"/> values to the current <see cref="StartTime"/>
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(double other)
		{
			double current = this.StartTime;

			if (current < other)
			{
				return -1;
			}
			else if (current == other)
			{
				return 0;
			}
			else
			{
				return 1;
			}
		}

		/// <summary>
		/// Default comparer, which attempts to call the <see cref="IComparable{T}.CompareTo(T)"/> on the property <see cref="StartTime"/>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public int CompareTo(object obj)
		{
			if (obj is AnimationStoryModel animationStoryModel)
			{
				return this.CompareTo(animationStoryModel.UID);
			}

			return 0;
		}

		#endregion
	}
}
