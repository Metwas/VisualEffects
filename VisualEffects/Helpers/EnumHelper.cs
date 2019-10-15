using System;

namespace VisualEffects.Helpers
{
	/// <summary>
	/// Static helper functions for handling <see cref="Enum"/> types
	/// </summary>
	public static class EnumHelper
	{
		/// <summary>
		/// Gets a declared <see cref="Enum"/> from a provided value
		/// </summary>
		/// <typeparam name="T">The generic type which must inherit <see cref="Enum"/></typeparam>
		/// <param name="value">A object value declared by the <see cref="Enum"/></param>
		/// <returns>The enum of type <typeparamref name="T"/></returns>
		public static Enum GetEnumFromValue<T>(object value) where T : Enum
		{
			return EnumHelper.GetEnumFromValue(typeof(T), value);
		}

		/// <summary>
		/// Gets a declared <see cref="Enum"/> from a provided value
		/// </summary>
		/// <param name="enumType">An <see cref="Enum"/> <see cref="Type"/></param>
		/// <param name="value">A object value declared by the <see cref="Enum"/></param>
		/// <param name="comparison">An optional comparison</param>
		/// <returns>The enum of type <paramref name="enumType"/></returns>
		public static Enum GetEnumFromValue(Type enumType, object value, StringComparison comparison = StringComparison.Ordinal)
		{
			try
			{
				Array enumValues = Enum.GetValues(enumType);
				int _index = 0;
				int _length = enumValues.Length;

				for (; _index < _length; _index++)
				{
					Enum _enum = enumValues.GetValue(_index) as Enum;
					if (_enum != null)
					{
						if(_enum.ToString().Equals(value.ToString(), comparison))
						{
							return _enum;
						}
					}
				}

				return null;
			}
			catch (Exception exception)
			{
				return null;
			}
		}
	}
}
