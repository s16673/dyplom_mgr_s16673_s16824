using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Switch : MonoBehaviour
{
    private Scene activeScene;
    public GameObject gameOver;
    public GameObject spawner;
    public Text TimerText;
    public float timeLeft = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        TimerText.text = timeLeft.ToString("00");
        if(timeLeft < 0)
        {
            GameOver();
            timeLeft = 0;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Application quit");
        }
    }
     public void Restart()
    {
        SceneManager.LoadScene(activeScene.buildIndex);
    }
    public void GameOver()
    {
        Destroy(GameObject.FindGameObjectWithTag("Prefabs"));
        Destroy(spawner);
        gameOver.SetActive(true);
    }
}
