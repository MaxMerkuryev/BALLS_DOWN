using UnityEngine;
using System.Collections.Generic;

namespace Core
{	
	[CreateAssetMenu(menuName = "Game Event")]
	public class GameEvent : ScriptableObject
	{
		private List<GameEventListener> _listeners = new List<GameEventListener>();

		public void Add(GameEventListener listener) => _listeners.Add(listener);
		public void Remove(GameEventListener listener) => _listeners.Remove(listener);

		public void Invoke()
		{
			foreach(var listener in _listeners)
				listener.Invoke();
		}
	}
}