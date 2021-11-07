using UnityEngine;
using UnityEngine.UI;
using Core;

namespace MovingUp
{
	public class FloatUI : MonoBehaviour
	{
		[SerializeField] private Float _variable;

		private Text _text;

		private void Awake() => _text = GetComponent<Text>();		
		private void OnEnable() => UpdateUI();
		public void UpdateUI() => _text.text = _variable.Value.ToString();
	}
}