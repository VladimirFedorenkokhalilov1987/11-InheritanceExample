using UnityEngine;
using System.Collections;
using ZOO;

public class Zoo : MonoBehaviour {

	#region Private
	iAnimal[] zoo = new iAnimal[3];
	#endregion

	// Use this for initialization
	void Start () 
	{
		zoo [0] = new Lion ();
		zoo [1] = new Panthera ();
		zoo [2] = new Elephant ();
		ShowZoo (zoo);
	}

	private void ShowZoo(iAnimal[] zoo)
	{
		if (zoo == null)
			return;
		foreach (var item in zoo)
		{
			print ("Type: "+item.GetType());
			item.Eat();
			item.Run();
			item.Hunt();

		}
	}

}

namespace ZOO
{
	public interface iAnimal
	{
		void Eat ();
	
		void Hunt ();
	
		void Run ();
		
	}
	
	public class Lion: iAnimal
	{
		 void Eat ()
		{
			Debug.Log ("Lion Eat");
		}
	
		void Hunt ()
		{
			Debug.Log ("Lion Hunt");
		}
		
		
		public void Run ()
		{
			Debug.Log ("Lion Run");
		}
		
	}
	
	public class Panthera: iAnimal
	{
	
		void Eat ()
		{
			Debug.Log ("Panthera Eat");
		}
	
		void Hunt ()
		{
			Debug.Log ("Panthera Hunt");
		}
	
	
		public void Run ()
		{
			Debug.Log ("Panthera Run");
		}
	}
	
	public class Elephant: iAnimal
	{
	
		void Eat ()
		{
			Debug.Log ("Panthera Eat");
		}
	
		public  void Run ()
		{
			Debug.Log ("Elephant Run");
		}
		public  void Hunt ()
		{
		}
	}
}
