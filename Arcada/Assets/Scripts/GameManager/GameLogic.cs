using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

    public static bool gameEnded;

	void Start () {
        gameEnded = false;
	}
	
	// Update is called once per frame
	void Update () {

    }

    public static void LoadNextLevel()
    {

    }

    public static void loadInterlevel()
    {
        SceneManager.LoadScene(0);
    }
}
