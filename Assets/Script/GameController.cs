using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject DeadText;
    public bool isDead = false;
    public float Velocity = -1.5f;
    public Text scoreText;
    private int score = 0;

    // Use this for initialization
    void Awake ()
    {
		if(instance == null)
        {
            instance = this;
        } else if(instance != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (isDead == true && Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
		
	}

    public void Scored()
    {
        if (isDead)
        {
            return;
        }
        score++;
        scoreText.text = "Score     " + score.ToString();

    }

    public void birdDied()
    {
        DeadText.SetActive(true);
        isDead = true;
    }
}
