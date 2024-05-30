//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public class ExEnemy : MonoBehaviour
{
    //���� �÷��̾ �ִ� ���ط�
    public int damage = 20;
    public ExPlayer targetPlayer;         //Ÿ�� �÷��̾�

    //�÷��̾�� ���ظ� �� �� ȣ��Ǵ� �Լ�
    public void AttackPlayer(ExPlayer player)
    {
        //�÷��̾�� ���ظ� �ش�.
        player.TakeDamage(damage);
        Debug.Log("�÷��̾� ����.");

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackPlayer(targetPlayer);
        }
    }
}
