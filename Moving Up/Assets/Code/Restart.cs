using UnityEngine;
using UnityEngine.SceneManagement;

namespace MovingUp
{
	public class Restart : MonoBehaviour
	{
		public void Invoke() => SceneManager.LoadScene(0);
	}
}