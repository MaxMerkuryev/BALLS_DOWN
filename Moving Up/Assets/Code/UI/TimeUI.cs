using UnityEngine;
using UnityEngine.UI;

namespace MovingUp
{
	[RequireComponent(typeof(Text))]
	public class TimeUI : MonoBehaviour
	{
		private Text _text;

		private void Awake() => _text = GetComponent<Text>();

		private void Update()
		{
			var time = Time.timeSinceLevelLoad;
			_text.text = $"{(time / 60f).ToString("00")}:{(time % 60).ToString("00")}";
		}
	}
}
