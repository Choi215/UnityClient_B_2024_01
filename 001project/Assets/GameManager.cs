using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Gamedata gamedata;
    void Start()
    {
        //���۽� GameData�� ������ Debug.Log�� �����ش�

        Debug.Log("Game Name : " + gamedata.gameName);
        Debug.Log("Game Score : " + gamedata.gameScore);
        Debug.Log("Game Active : " + gamedata.isGameActive);


    }
}
