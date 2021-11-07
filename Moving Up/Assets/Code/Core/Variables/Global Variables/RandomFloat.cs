using UnityEngine;

namespace Core
{
	[CreateAssetMenu(menuName = "Game Variable/Random Float")]
	public class RandomFloat : ScriptableObject
	{
		[SerializeField] private float _min;
		[SerializeField] private float _max;

		public float Value => Random.Range(_min, _max);
	}
}