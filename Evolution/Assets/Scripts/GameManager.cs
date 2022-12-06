using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverMenu, ComplatedMenu;
    public bool timeSc, GameOverbool, Complatedbool;
    public void Start()
    {

    }
    public void Update()
    {
        timeSc = GameObject.FindWithTag("Player").GetComponent<PlayerController>().timeSc;
        GameOverbool = GameObject.FindWithTag("Player").GetComponent<PlayerController>().GameOver;
        Complatedbool = GameObject.FindWithTag("Player").GetComponent<PlayerController>().Complated;
        if (timeSc == false && GameOverbool == true)
        {
            GameOver();
        }
        if(timeSc == false && Complatedbool == true)
        {
            Complated();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameOverMenu.SetActive(false);
    }


    public void GameOver()
    {
        GameOverMenu.SetActive(true);
    }
    public void Complated()
    {
        ComplatedMenu.SetActive(true);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

