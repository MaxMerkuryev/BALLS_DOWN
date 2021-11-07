using System;
using UnityEngine;
using Core;

namespace MovingUp
{
	public class Player : MonoBehaviour
	{
		[SerializeField] private float _initialHealth;

		[SerializeField] private GameActionFloat DamageAction;

		[SerializeField] private GameEvent Damaged;
		[SerializeField] private GameEvent Died;

		[SerializeField] private Float InitialHeatlhRef;
		[SerializeField] private Float CurrentHealthRef;
		
		private void OnEnable()
		{
			InitialHeatlhRef.Value = _initialHealth;
			CurrentHealthRef.Value = _initialHealth;

			DamageAction.Add(Damage);
		}

		private void OnDisable()
		{
			DamageAction.Remove(Damage);
		}

		public void Damage(float amount)
		{
			if(HasDied())
				return;

			CurrentHealthRef.Value -= amount;

			Damaged?.Invoke();

			if(HasDied())
				Died?.Invoke();
		}

		private bool HasDied()
		{
			return CurrentHealthRef.Value <= 0;
		}
	}
}
