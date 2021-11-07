using UnityEngine;
using Core;

namespace MovingUp
{
	public class Reward : MonoBehaviour
	{
		[SerializeField] private Float _gameTimeCurrent;

		[SerializeField] private RandomFloat _rewardAmount;
		[SerializeField] private Curve _rewardMultiplier;

		[SerializeField] private Float _score;

		public void Apply()
		{
			var multiplier = _rewardMultiplier.Value(_gameTimeCurrent.Value);
			_score.Value += (int) _rewardAmount.Value;
		}
	}
}