using UnityEngine;
using UnityEngine.Events;

namespace MovingUp
{
	public class EscapeTrigger : MonoBehaviour
	{
		[SerializeField] private UnityEvent Escaped;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
				Escaped.Invoke();
		}
	}
}
