using UnityEngine;
using UnityEngine.UI;

public class SetScores : MonoBehaviour
{
	public GameObject kills;
	public GameObject deaths;

	public void SetValues(GameObject playerRef)
	{
		Player player = playerRef.GetComponent<Player>();
		kills.GetComponent<Text>().text = player.score.ToString();
		kills.GetComponent<Text>().color = player.colour;

		deaths.GetComponent<Text>().text = player.deaths.ToString();
		deaths.GetComponent<Text>().color = player.colour;
	}
}
