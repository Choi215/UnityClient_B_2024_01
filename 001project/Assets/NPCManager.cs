using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public Entity_dialog entity_Dialog;

    public void Start()
    {

    }

    public Entity_dialog.Param GetParamData(int npc, int gamestate)
    {

        foreach (Entity_dialog.Param param in entity_Dialog.sheets[0].list)
        {
            if (param.npc == npc && param.gamestate == gamestate)
            {
                return param;
            }
        }
        return null;
    }
}
