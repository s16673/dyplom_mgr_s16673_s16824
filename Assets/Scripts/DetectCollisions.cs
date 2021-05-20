using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    
    //private string wallTagYellow = "Yellow";
    public string wallTag;
    public Text scoreText;
    private int score;
    private float boundary = -8f;

    private void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < boundary)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //other = GameObject.FindGameObjectWithTag("Red");
       if (other.CompareTag(wallTag))
            // && gameObject.CompareTag(wallTagYellow))//(GameObject.FindGameObjectWithTag(collisionTag))
       {
            score = score ++;
            SetScore();
            Destroy(gameObject, 0.1f);
            
            Debug.Log("Collided");
       }
    }
    void SetScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
