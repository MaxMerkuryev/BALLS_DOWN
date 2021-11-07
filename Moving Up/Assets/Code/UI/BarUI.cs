using UnityEngine;
using UnityEngine.UI;
using Core;

namespace MovingUp
{
	[RequireComponent(typeof(Image))]
	public class BarUI : MonoBehaviour
	{
		[SerializeField] private Float _current;
		[SerializeField] private Float _initial;

		private Image _bar;

		private void Awake() => _bar = GetComponent<Image>();
		public void UpdateFill() => _bar.fillAmount = _current.Value / _initial.Value;
	}
}
