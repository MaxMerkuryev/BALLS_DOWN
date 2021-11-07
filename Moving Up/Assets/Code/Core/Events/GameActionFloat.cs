using UnityEngine;
using System.Collections.Generic;
using System;

namespace Core
{
	[CreateAssetMenu(menuName = "Game Action<float>")]
	public class GameActionFloat : ScriptableObject
	{
		private Action<float> _action;

		public void Add(Action<float> listenerAction) => _action += listenerAction;
		public void Remove(Action<float> listenerAction) => _action -= listenerAction;

		public void Invoke(float value)
		{
			_action?.Invoke(value);
		}
	}
}
