using UnityEngine;
using System.Collections;

public class RespawnManager : MonoBehaviour
{
	GameManager GM;

	public float respawnTime;
	private float counter = 0;

	// Use this for initialization
	void Start ()
	{
		GM = GameManager.Instance;
	}

	void RespawnPlayer(Player playerRef)
	{
		//start coroutine
		StartCoroutine(RespawnTimer(playerRef));
		playerRef.gameObject.SetActive(false);

		if (playerRef != null)
		{
			playerRef.gameObject.SetActive(false);
			//ps.EnableEmission(true);
		}
	}

	IEnumerator RespawnTimer(Player playerRef)
	{

		yield return new WaitForSeconds(respawnTime);
		playerRef.gameObject.SetActive(true);

		//playerRef.transform.position = ps.transform.position;
		//ps.EnableEmission(false);
		//ps.SetEmissionRate(1);
		//emissioinRate = 1;
	}
}
