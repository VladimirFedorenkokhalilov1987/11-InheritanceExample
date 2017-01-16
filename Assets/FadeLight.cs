using UnityEngine;
using System.Collections;

public class FadeLight : BaseLight {

	[SerializeField]
	private float DefaultIntensety =2f;

	[SerializeField, Range(0.001f,1f)]
	private float SpeedLoss;

	private bool _turnOn = true;

	//private Light _light;
	//private Light MyLight {
	//	get {
	//		if (_light == null) {
	//			_light = GetComponent<Light> ();
	//		}
	//		return _light;
	//	}
	//}
	public override void TurnLight()
	{
		_turnOn = true;
		if (MyLight == null)return;
	}
	
	public override void OffLight()
	{
		_turnOn = false;
		if (MyLight == null)return;

	}

	private void Update()
	{
		if (MyLight == null)
			return;
		if (_turnOn) {
			if(MyLight.intensity==DefaultIntensety) return;
			if(MyLight.intensity>DefaultIntensety)
			{
				MyLight.intensity=DefaultIntensety;
				return;
			}

			MyLight.intensity += Time.deltaTime*SpeedLoss;
			

		} else 
		{
			if(MyLight.intensity==0) return;
			if(MyLight.intensity<0)
			{
				MyLight.intensity=0;
				return;
			}
			
			MyLight.intensity -= Time.deltaTime*SpeedLoss;
		}
	}

	public string TestString = "TestString";

}
