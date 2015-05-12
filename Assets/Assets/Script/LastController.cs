using UnityEngine;
using System.Collections;

public class LastController : MonoBehaviour {
		
		// Use this for initialization
		void Start () {
			
		}
		
		void Update () {
			
		}
		
		void OnCollisionEnter2D (Collision2D coll)
		{
			
			if (coll.gameObject.tag == "tile2") 
				Application.LoadLevel ("SceneThankYou");
			
		}	
	}
