using UnityEngine;

namespace MovingUp
{
	[RequireComponent(typeof(SpriteRenderer))]
	public class BallExplosion : MonoBehaviour
	{
		[SerializeField] private ParticleSystem _explosionPrefab;

		private SpriteRenderer _spriteRenderer;

		private void Awake()
		{
			_spriteRenderer = GetComponent<SpriteRenderer>();
		}

		public void Explode()
		{
			var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity, transform.parent).main;
			explosion.startColor = _spriteRenderer.color;
		}
	}
}