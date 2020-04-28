using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DificcultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int Difficulty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDificculty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDificculty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManager.StartGame(Difficulty);
    }
}
