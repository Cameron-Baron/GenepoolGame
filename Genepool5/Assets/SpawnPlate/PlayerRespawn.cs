using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
	public float respawnTimer;

	public GameObject player;
	private Player playerRef;

	public ParticleSystem ps;
	public float emissioinRate;

	private GameManager GM;
	
	void Start ()
	{
		GM = GameManager.Instance;

		for (int i = 0; i < GM.players.Count; i++)
		{
			if (GM.players[i].GetComponent<Player>().playerID == gameObject.name.Length - 1)
			{
				player = GM.players[i];
				playerRef = player.GetComponent<Player>();
			}
		}

		ps.EnableEmission(false);
		emissioinRate = ps.GetEmissionRate();
		if (player == null)
			this.enabled = false;
	}

	public void Update()
	{
		//couroutine
		if (playerRef.health.currentHP <= 0)
		{
			if (player != null)
			{
				player.gameObject.SetActive(false);
				ps.EnableEmission(true);
			}

			StartCoroutine(RespawnTimer());
			emissioinRate += Time.deltaTime * 1000;
			ps.SetEmissionRate(emissioinRate);
		}
	}

	IEnumerator RespawnTimer()
	{
		yield return new WaitForSeconds(respawnTimer);
		player.gameObject.SetActive(true);
		player.transform.position = ps.transform.position;
		ps.EnableEmission(false);
		ps.SetEmissionRate(1);
		emissioinRate = 1;
	}
}
