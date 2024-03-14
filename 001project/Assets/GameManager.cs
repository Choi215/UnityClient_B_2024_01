using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Gamedata gamedata;
    void Start()
    {
        //시작시 GameData의 내역을 Debug.Log로 보여준다

        Debug.Log("Game Name : " + gamedata.gameName);
        Debug.Log("Game Score : " + gamedata.gameScore);
        Debug.Log("Game Active : " + gamedata.isGameActive);


    }
}
