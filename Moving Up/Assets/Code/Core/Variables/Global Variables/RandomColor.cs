using UnityEngine;

namespace Core
{
	[CreateAssetMenu(menuName = "Game Variable/Random Color")]
	public class RandomColor : ScriptableObject
	{
		[SerializeField] private Gradient _gradient;

		public Color Value => _gradient.Evaluate(Random.Range(0f, 1f));
	}
}