using UnityEngine;

namespace Core
{
	[CreateAssetMenu(menuName = "Game Variable/Curve")]
	public class Curve : ScriptableObject
	{
		[SerializeField] private AnimationCurve _curve;

		public float Value(float time) => _curve.Evaluate(time);
	}
}


