//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.Linq;

//public class ExPlayerManager : MonoBehaviour
//{
//    public List<PlayerData> playerDatas = new List<PlayerData>();

//    private void Start()
//    {
//        for(int i =0; i < 100; i++)
//        {
//            playerDatas playerData = new PlayerData()
//            {
//                playerName = "�÷��̾� " + i.ToString(),
//                playerLevel = Random.Range(0, 20)
//            };

//            playerDatas.Add(playerData);

//        }

//        //�÷��̾� ������ ����Ʈ���� ������ 10�̻��� �÷��̾ ã�´�
//        var highLevelPlayers = playerDatas.Where(PlayerData => PlayerData.playerLevel >= 10);

//        foreach (var Player in highLevelPlayers)
//        {
//            Debug.Log("High Level Player : " + Player.playerName + " Lv : " + Player.playerLevel);
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
