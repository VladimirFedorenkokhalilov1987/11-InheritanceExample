using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {
	[SerializeField]
	BaseLight[] _lights;

	private FadeLight _fadeLight;

	public void Start()
	{
		//FadeLight temp = (FadeLight)_lights [0];
		FadeLight temp1 = _lights [0] as FadeLight;
		//bool temp2 = _lights [0] is FadeLight;
	}

	//[SerializeField]
	//private OrdinaryLight _ordinaryLight;

	//[SerializeField]
	//private FadeLight _FadeLight;

	//[SerializeField]
	//private SmuseLight _smuseLight;

	private void OnGUI()
	{
		if (GUI.Button (new Rect (10, 10, 100, 25), "On")) {
			TurnOnLight();
		}

		if (GUI.Button (new Rect (150, 10, 100, 25), "Off")) {
			TurnOffLight();
		}
	}

	private void TurnOnLight()
	{
		//if (_ordinaryLight == null)
		//	return;
		//_ordinaryLight.TurnLight();
		//if (_FadeLight == null)
		//	return;
		//_FadeLight.TurnLight();
		//if (_smuseLight == null)
		//	return;
		//_smuseLight.TurnLight();
		Setactive (true);
	}

	private void TurnOffLight()
	{
		//if (_ordinaryLight == null)
		//	return;
		//_ordinaryLight.OffLight();
		//if (_FadeLight == null)
		//	return;
		//_FadeLight.OffLight();
		//if (_smuseLight == null)
		//	return;
		//_smuseLight.OffLight();
		Setactive (false);
	}

	void Setactive(bool on)
	{
		foreach (var Item in _lights)
		{
			if (Item == null)
				continue;
		if(on)
				Item.TurnLight();
			else		Item.OffLight();
		}
	}

	private bool isEntered;

	private void OnTriggerStay(Collider other)
	{
		isEntered = true;
	}
	private void OnTriggerExit(Collider other)
	{
		isEntered = false;
	}
	
}