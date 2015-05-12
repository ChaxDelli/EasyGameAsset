using UnityEngine;
using System.Collections;

public class HitMeController : MonoBehaviour {

	void Start (){

	}

	void Update (){

	}

	//to proceed to next level once HitMe will collide
	void OnCollisionEnter2D (Collision2D coll)
	{

		if (coll.gameObject.tag == "enemy")
			Application.LoadLevel ("SceneContinue");
	}
}

