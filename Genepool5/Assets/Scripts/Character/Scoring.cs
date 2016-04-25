using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
	public GameObject healthbar;
	private int getColour = 0;

	GameObject playerRef;

	public Text score
	{
		get { return GetComponent<Text>(); }
	}

	void Start()
	{
		playerRef = healthbar.GetComponent<HealthBar>().playerRef;

		if (healthbar == null || playerRef == null)
		{
			gameObject.SetActive(false);
		}
		else if (getColour == 0 && playerRef != null)
		{
			score.color = playerRef.GetComponent<Player>().indicator.GetComponent<Renderer>().material.GetColor("_EmissionColor");
			getColour++;
		}
	}

	void Update ()
	{
		
		score.text = playerRef.GetComponent<Player>().score.ToString();
	}
}
