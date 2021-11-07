using UnityEngine;

namespace MovingUp
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleSystemCleanup : MonoBehaviour
	{
		private void Awake()
		{
			var time = GetComponent<ParticleSystem>().main.duration;

			Invoke(nameof(Cleanup), time);
		}

		private void Cleanup() => Destroy(gameObject);
	}
}
