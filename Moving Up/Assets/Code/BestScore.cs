using UnityEngine;
using Core;

namespace MovingUp
{
	public class BestScore : MonoBehaviour
	{
		[SerializeField] private Float _currentScore;
		[SerializeField] private Float _bestScore;

		public void SetValue()
		{
			if (_currentScore.Value > _bestScore.Value)
				_bestScore.Value = _currentScore.Value;
		}
	}
}
