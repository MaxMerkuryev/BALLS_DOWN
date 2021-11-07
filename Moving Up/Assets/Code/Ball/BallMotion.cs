using UnityEngine;
using Core;

namespace MovingUp
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class BallMotion : MonoBehaviour
	{
		[SerializeField] private Float _gameTimeCurrent;
		[SerializeField] private RandomFloat _speed;
		[SerializeField] private Curve _speedMultiplier;
		[SerializeField] private Curve _initialThrust;

		private Rigidbody2D _rigidbody;

		private float _currentSpeed;
		private float _lifeTime;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
			_currentSpeed = _speed.Value * _speedMultiplier.Value(_gameTimeCurrent.Value);
		}

		private void Update() => _lifeTime += Time.deltaTime;

		private void FixedUpdate()
		{
			var thrust = _initialThrust.Value(_lifeTime);
			var offset = Vector2.down * ((_currentSpeed + thrust) * Time.deltaTime);

			_rigidbody.MovePosition(_rigidbody.position + offset);
		}
	}
}