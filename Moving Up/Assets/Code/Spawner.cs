using UnityEngine;
using System.Collections;
using Core;

namespace MovingUp
{
	[RequireComponent(typeof(SpawnZone))]
	public class Spawner : MonoBehaviour
	{
		[SerializeField] private float _delay;
		[SerializeField] private Float _gameTimeCurrent;
		[SerializeField] private Curve _frequency;
		[SerializeField] private RandomFloat _count;

		[SerializeField] private GameObject _object;

		private SpawnZone _spawnZone;

		private void Awake()
		{
			_spawnZone = GetComponent<SpawnZone>();
		}

		private void Start()
		{
			StartCoroutine(Spawning());
		}

		private IEnumerator Spawning()
		{
			yield return new WaitForSeconds(_delay);

			while(true)
			{
				for(int i = 0; i < _count.Value; i++)
				{
					var spawnPosition = _spawnZone.GetNewPosition();
					Instantiate(_object, spawnPosition, Quaternion.identity, transform);
				}

				yield return new WaitForSeconds(1f / _frequency.Value(_gameTimeCurrent.Value));
			}
		}

	}
}
