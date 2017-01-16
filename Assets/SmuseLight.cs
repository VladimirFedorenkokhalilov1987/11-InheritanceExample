using UnityEngine;
using System.Collections;

public class SmuseLight : BaseLight {
	
	[SerializeField, Range (0,10)]
	private float DefaultIntensety =80f;
	
	[SerializeField, Range(0.001f,100f)]
	private float SpeedLoss=80f;
	
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
	
	private  void Update()
	{
		if (MyLight == null)
			return;
		if (_turnOn) {
			if(MyLight.spotAngle==DefaultIntensety) return;
			if(MyLight.spotAngle>DefaultIntensety)
			{
				MyLight.spotAngle=DefaultIntensety;
				return;
			}
			
			MyLight.spotAngle += Time.deltaTime*SpeedLoss;
			
			
		} else 
		{
			if(MyLight.spotAngle==0) return;
			if(MyLight.spotAngle<0)
			{
				MyLight.spotAngle=0;
				return;
			}
			
			MyLight.spotAngle -= Time.deltaTime*SpeedLoss;
		}
	}

	private void OnTriggerStay(Collider col)
	{

	}

}
