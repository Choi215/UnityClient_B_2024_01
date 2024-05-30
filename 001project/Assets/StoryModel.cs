using STOTYGAME;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;


[CreateAssetMenu(fileName = "NewStory", menuName = "ScriptableObjects/StoryModel")]
public class StoryModel : ScriptableObject
{
    public int storyNumber;
    public Texture2D MainImage;
    public bool storyDone;

    public enum STORYTYPE
    {
        MAIN,
        SUB,
        SERIAL
    }

    public STORYTYPE storyType;

    [TextArea(10, 10)]
    public string storyText;
    public Option[] options;

    [System.Serializable]
    public class Option
    {
        public string optionText;
        public buttonText;

        public EventCheck eventCheck;
    }

    [System.Serializable]
    public class EventCheck
    {
        public int checkValue;

        public enum EventType : int
        {
            NONE,
            GoToBattle,
            CheckSTR,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA
        }

        public EventType type;

        public Result[] successRusult;
        public Result[] failResult;
    }

    [System.Serializable]
    public class Result
    {
        public enum ResultType : int
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GoToRandomStory,
            GoToEnding

        }
        public ResultType resultType;
        public int value;
        public Stats stats;
    }

}
