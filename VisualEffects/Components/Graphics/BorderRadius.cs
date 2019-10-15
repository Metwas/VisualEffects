namespace VisualEffects.Components.Graphics
{
	/// <summary>
	/// Represents border structure with the values changing the curve radius
	/// </summary>
	public struct BorderRadius
	{
		#region Contructors

		/// <summary>
		/// Initializes all properties to a single uniform value
		/// </summary>
		/// <param name="value"></param>
		public BorderRadius(double value)
			: this(value, value, value, value)
		{
		}

		/// <summary>
		/// Initializes the vertical and horizontal values independantly
		/// </summary>
		/// <param name="vertical"></param>
		/// <param name="horizontal"></param>
		public BorderRadius(double vertical, double horizontal)
			: this(vertical, horizontal, vertical, horizontal)
		{
		}

		/// <summary>
		/// Initializes each corner with a unique value
		/// </summary>
		/// <param name="top"></param>
		/// <param name="right"></param>
		/// <param name="bottom"></param>
		/// <param name="left"></param>
		public BorderRadius(double topLeft, double topRight, double bottomLeft, double bottomRight)
		{
			this.TopLeft = topLeft;
			this.TopRight = topRight;
			this.BottomLeft = bottomLeft;
			this.BottomRight = bottomRight;
		}

		#endregion

		/// <summary>
		/// The top-left border value
		/// </summary>
		public double TopLeft { get; set; }

		/// <summary>
		/// The top-right border value
		/// </summary>
		public double TopRight { get; set; }

		/// <summary>
		/// The bottom-left border value
		/// </summary>
		public double BottomLeft { get; set; }

		/// <summary>
		/// The bottom-right border value
		/// </summary>
		public double BottomRight { get; set; }

		#region Functions

		/// <summary>
		/// Returns a formatted string representation for this margin structure
		/// </summary>
		/// <returns><see cref="string"/></returns>
		public override string ToString()
		{
			return $"{ this.TopLeft },{ this.TopRight },{ this.BottomLeft },{ this.BottomRight }";
		}

		#endregion
	}
}
