using UnityEngine;
using UnityEngine.EventSystems;

namespace MovingUp
{
	public class RaycastDestroyer : MonoBehaviour
	{
		private Camera _camera;

		private void Awake()
		{
			_camera = Camera.main;
		}

		public void TryHitTarget()
		{
			if (EventSystem.current.IsPointerOverGameObject())
				return;

			var worldMousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
			var raycastHit = Physics2D.Raycast(worldMousePosition, Vector2.zero);

			if(raycastHit == false)
				return;

			if(raycastHit.collider.TryGetComponent(out Destroyable destroyable))
				destroyable.Hit();
		}

		private void Update()
		{
			if(Input.GetMouseButtonDown(0))
				TryHitTarget();
		}
	}
}
