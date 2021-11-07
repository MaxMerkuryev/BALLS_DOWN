using UnityEngine;
using Core;

namespace MovingUp
{
	[RequireComponent(typeof(SpriteRenderer))]
	public class SpriteColor : MonoBehaviour
	{
		[SerializeField] private RandomColor _colorRef;

		public Color Current { get; private set; }

		private void Awake() => GetComponent<SpriteRenderer>().color = _colorRef.Value;

	}
}
