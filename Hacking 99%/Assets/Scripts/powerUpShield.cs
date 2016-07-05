using UnityEngine;
using System.Collections;

public class powerUpShield : MonoBehaviour
{
	public GameObject pop;
	private Player getDown;
	private Vector3 posicaoPop;

	public Transform playerPosition;
	public GameObject shield;
	
	void Start()
	{
		getDown = GameObject.FindGameObjectWithTag("Player1").GetComponent<Player>() as Player;
		Vector2 novaPos = new Vector2(getDown.transform.position.x, getDown.transform.position.y - 2f);
		Instantiate(pop, novaPos, Quaternion.identity);
	}
	void Update()
	{
		Destroy(gameObject, 45);
	}

	void OnCollisionEnter2D(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "Player1")
		{
			SoundEffectScript.Instance.MakeColetaSound ();
			Debug.Log ("PEGOU O ESCUDO");
			Destroy (gameObject);
			Instantiate(shield, playerPosition.transform.position, Quaternion.identity);
		}
	}
}