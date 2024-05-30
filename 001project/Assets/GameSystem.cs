using UnityEditor;
using System.Text;
using UnityEngine.UI;
using TMPro;
using STORYGAME;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME
{
#if UNITY_EDITOR
    [CustomEditor(typeof(GameSystem))]
    public class GameSystemEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GameSystem gameSystem = (GameSystem)target;

            if (GUILayout.Button("Reset Story Models"))
            {
                gameSystem.ResetStoryModels();
            }
        }
    }
#endif
}
public class GameSystem : MonoBehaviour
{
    public static GameSystem Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum GAMESTATE
    {
        STORYSHOW,
        STORYEND,
        ENDMODE
    }
    public GAMESTATE state;
    public Stats stats;
    public StoryModel[] storyModels;
    public int currentStoryIndex = 0;

    public void ApplyChoice(StoryModel.Result result)
    {
        switch(result.resultType)
        {
            case StoryModel.Result.ResultType.ChangeHp;

                ChangeStats(result);
                break;

            case StoryModel.Result.ResultType.GoToNextStory;
                currentStoryIndex = result.value;

                break;
        }
    }


    public void ChangeStats(StoryModel.Result result)
    {
        if (result.stats.hpPoint > 0) stats.hpPoint += result.stats.hpPoint;
        if (result.stats.spPoint > 0) stats.spPoint += result.stats.spPoint;

        if (result.stats.currentHpPoint > 0) stats.currentHpPoint += result.stats.currentHpPoint;
        if (result.stats.currentSpPoint > 0) stats.currentSpPoint += result.stats.currentSpPoint;
        if (result.stats.currentXpPoint > 0) stats.currentXPoint += result.stats.currentXpPoint;

        if (result.stats.strength > 0) stats.strength += result.stats.strength;
        
    }
    StoryModel RandomStory(0)
    {
        storyModels tempStoryModels = null;

        List<StoryModel> StoryModelList = new List<StoryModel>();

        for (int i = 0; i < storyModels.Length; i++)
        {
            if (storyModels[i].storyType == StoryModel.STORYTYPE.MAIN)
            {
                StoryModelList.Add(storyModels[i]);
            }
        }

        tempStoryModels = StoryModelList[Random.Range(0, StoryModelList.Count)];
        currentStoryIndex = tempStoryModels.storyNumber;
        Debug.Log("currentStoryIndex" + currentStoryIndex);

        return tempStoryModels;
    }
    StoryModel FindStoryModel(int number)
    {
        StoryModel tempStoryModels = null;

        for(int i = 0; i < storyModels.Length; i++)
        {
            if (storyModels[i].storyNumber == number)
            {
                tempStoryModels = storyModels[i];
                break;
            }
        }
        return tempStoryModels;
    }

#if UNITY_EDITOR
    [ContextMenu("Reset Story Models")]
    public void ResetStoryModels()
    {
        storyModels = Resources.LoadAll<StoryModel>("");
    }
#endif
}
