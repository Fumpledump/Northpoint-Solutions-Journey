using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
	//Door Setting
	public int portalSetting = 0;
	//Selected Level
	public string portalLevel = "None";

	//Triggers Code when the player collides with the portal
	void OnTriggerEnter2D(Collider2D col)
	{
		//Makes sure it is the player
		if (col.CompareTag("Player"))
		{
			//Checks the setting of the portal
			if (portalSetting == 1)
			{
				//if setting is 1 it just loads the next scene
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
			else if (portalSetting == 2 && portalLevel != "None")
			{
				//if setting is 2 it loads the provided level
				SceneManager.LoadScene(portalLevel);
			}
		}
	}
}
