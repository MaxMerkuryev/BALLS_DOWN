using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{	
	public class GameEventListener : MonoBehaviour
	{
		[SerializeField] private List<GameEvent> _events;
		[SerializeField] public UnityEvent _response; 

		void OnEnable()
		{
			foreach(var e in _events)
				e.Add(this);
		}

		void OnDisable()
		{
			foreach(var e in _events)
				e.Remove(this);
		}

		public void Invoke() => _response.Invoke();
	}
}