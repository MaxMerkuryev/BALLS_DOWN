using UnityEngine;

namespace MovingUp
{
	public class Menu : MonoBehaviour
	{
		[SerializeField] private GameObject _content;

		public void Invoke()
		{
			Time.timeScale = 1f - Time.timeScale;
			_content.SetActive(!_content.activeSelf);
		}
	}
}
