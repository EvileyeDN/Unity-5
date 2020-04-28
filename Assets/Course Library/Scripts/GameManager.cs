using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject titleScreen;
    public List<GameObject> targets;
    public Button restartButton;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOverText;
    private int score;
    private float spawnRate = 1.0f;
    public bool isGameActive;
    

    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }   
    }
   public void UpdateScore(int scoretoAdd)
    {
        score += scoretoAdd;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        GameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int Difficulty)
    {
        spawnRate = spawnRate / Difficulty;
        isGameActive = true;
        score = 0;
        StartCoroutine(SpawnTarget());

        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }
}
