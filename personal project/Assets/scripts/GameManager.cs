using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public Image gameOverback;
    public Button startButton;
    public GameObject titleScreen;
    public TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        

    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        gameOverback.gameObject.SetActive(true);
        timer.gameObject.SetActive(false);

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame()
    {
        isGameActive = true;
        startButton.gameObject.SetActive(false);
        titleScreen.gameObject.SetActive(false);
        timer.gameObject.SetActive(true);
    }
    public void StartTime()
    {
        

        
        
    }
    

}
