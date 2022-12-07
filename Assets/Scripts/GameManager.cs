using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager {get; private set;}

    public PlayerNeeds _PlayerStats = new PlayerNeeds(100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 500);


    // Start is called before the first frame update
    void Awake()
    {
        if(gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
}
