using UnityEngine;
using System.Collections;

public class ShieldPowerUp : MonoBehaviour 
{
	public float maxSpeed = 5f;
	public GameObject shild;


	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (Player.positionPlayerX, Player.positionPlayerY, 1);
	}

	void OnCollisionEnter2D(Collision2D colisor)
	{
		/*if (colisor.gameObject.tag == "inimigo00") 
		{
			Destroy(colisor.gameObject);
		}

		if (colisor.gameObject.tag == "inimigo01") 
		{
			Destroy(colisor.gameObject);
		}

		if (colisor.gameObject.tag == "inimigo02") 
		{
			Destroy(colisor.gameObject);
		}

		if (colisor.gameObject.tag == "inimigo03") 
		{
			Destroy(colisor.gameObject);
		}*/

		if (colisor.gameObject.tag == "tiroInimigo") 
		{
			Destroy(colisor.gameObject);
		}
	}
}