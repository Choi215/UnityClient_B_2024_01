using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEnemy : MonoBehaviour
{
    //���� �÷��̾� ���� �ִ� ���ط�
    public int damage = 20;
    public ExPlayer targetPlayer;   //Ÿ�� �÷��̾�

    //�÷��̾�� ���ظ� �� ��
    public void AttackPlayer(ExPlayer player)
    {
        //�÷��̾�� ���ظ� �ش�
        Player.TakeDamage(damage);
        Debug.Log("�÷��̾� ����");
    }
}
