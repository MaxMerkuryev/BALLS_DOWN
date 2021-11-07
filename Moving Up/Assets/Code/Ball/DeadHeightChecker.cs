using UnityEngine;
using UnityEngine.Events;
using Core;

namespace MovingUp
{
	public class DeadHeightChecker : MonoBehaviour
	{
		[SerializeField] private RandomFloat _damageAmount;
		[SerializeField] private GameActionFloat _damageAction;

		private float _deadHeight;

		private void Awake()
		{
			var screenDownBorder = Camera.main.ViewportToWorldPoint(new Vector2(0.5f, 0));
			_deadHeight = screenDownBorder.y - 0.5f;
		}

		private void Update()
		{
			if(PassedDeadHeight() == false)
				return;

			ApplyDamageToPlayer();
			Destroy(gameObject);
		}

		private bool PassedDeadHeight() => transform.position.y < _deadHeight;

		public void ApplyDamageToPlayer() => _damageAction.Invoke(_damageAmount.Value);
	}
}
