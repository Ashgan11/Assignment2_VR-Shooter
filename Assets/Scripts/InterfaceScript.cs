using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfaceScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject gameStateObject;
    private GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState = gameStateObject.GetComponent<GameState>();
        timerText.text = gameState.getTime().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = ((int)gameState.getTime()).ToString();
    }
}
