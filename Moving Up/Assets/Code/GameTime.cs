using UnityEngine;
using Core;

namespace MovingUp
{
	public class GameTime : MonoBehaviour
	{
		[SerializeField] private float _gameTimeMax;
		[SerializeField] private Float _gameTimeCurrent;

		private void Update()
		{
			_gameTimeCurrent.Value = Time.timeSinceLevelLoad / _gameTimeMax;
		}
	}
}