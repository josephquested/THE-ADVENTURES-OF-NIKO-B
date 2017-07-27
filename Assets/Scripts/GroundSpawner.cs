using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour {

	public GameObject blockPrefab;

	void OnTriggerExit2D (Collider2D col)
	{
		if (col.tag == "Block")
		{
			Spawn();
		}
	}

	void Spawn ()
	{
		// if (Random.Range(0, 10) < 8f)
		// {
			Instantiate(blockPrefab, transform.position, transform.rotation);
		// }
	}
}
