using UnityEngine;

namespace MovingUp
{
	public class SpawnZone : MonoBehaviour
	{
		[SerializeField] private float _positionVerticalOffset = 0.5f;

		private Camera _camera;

		private void Awake()
		{
			_camera = Camera.main;
		}

		public Vector2 GetNewPosition()
		{
			var horizontal = Random.Range(0.1f, 0.9f);
			var position = _camera.ViewportToWorldPoint(new Vector2(horizontal, 1));

			position.y += _positionVerticalOffset;

			return position;
		}
	}
}
