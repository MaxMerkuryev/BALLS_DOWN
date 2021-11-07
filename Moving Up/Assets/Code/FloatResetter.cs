using UnityEngine;
using Core;

namespace MovingUp
{
	public class FloatResetter : MonoBehaviour
	{
		[SerializeField] private Float _variable;

		private void Awake() => _variable.Value = 0f;
	}
}
