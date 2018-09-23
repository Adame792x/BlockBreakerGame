using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

    // config params
    [Range(0.2f,5f)][SerializeField] float gameSpeedScale = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] Text scoreNumber;
    
    
    // state variables
    [SerializeField] int currentScore = 0;


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    private void Start()
    {
        scoreNumber.text = currentScore.ToString();
    }
    

    void Update ()
    {
        Time.timeScale = gameSpeedScale;
	}


    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreNumber.text = currentScore.ToString();
    }


    public void ResetGame()
    {
        currentScore = 0;
        scoreNumber.text = currentScore.ToString();
        Destroy(gameObject);
    }



}
