using UnityEngine;
using System.Collections;

public class SpawnPlateParticles : MonoBehaviour
{
	public float timer;

	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(new Vector3(0 , 0, Time.deltaTime * 100));

	}
}
