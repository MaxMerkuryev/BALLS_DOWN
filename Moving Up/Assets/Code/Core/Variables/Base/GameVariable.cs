using UnityEngine;

namespace Core
{
	public class GameVariable<T> : GameEvent
	{
		private T _value;

		public T Value
		{
			get => _value;

			set
			{
				_value = value;
				Invoke();
			}
		}
	}
}
