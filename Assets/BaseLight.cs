using UnityEngine;
using System.Collections;

public class BaseLight : MonoBehaviour {

	private Light _light;
	protected Light MyLight {
		get {
			if (_light == null) {
				_light = GetComponent<Light> ();
			}
			return _light;
		}
	}
	public virtual void TurnLight()
	{
		print ("On");
		if (MyLight == null)
			return;
		MyLight.enabled = true;
	}
	
	public virtual void OffLight()
	{if (MyLight == null)
		return;
		MyLight.enabled = false;
		
	}
}
