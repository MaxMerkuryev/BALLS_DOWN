using UnityEngine;
using UnityEngine.Events;

namespace MovingUp
{
	public class Destroyable : MonoBehaviour
	{
		[SerializeField] private UnityEvent Destroyed;

		public void Hit()
		{
			Destroyed.Invoke();
			Destroy(gameObject);
		}
	}
}
