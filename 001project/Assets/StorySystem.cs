using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using System;

public class StorySystem : MonoBehaviour
{
    public static StorySystem instance;

    public StoryModel currentStoryModel;

    public enum TEXTSYSTEM
    {
        DOING,
        SELECT,
        DONE
    }

    public float delay = 0.1f;
    public string fullText;
    public string currentText = "";
    public Text textComponent;
    public Text stortIndex;
    public Image imageComponet;

    public Button[] buttonWay = new Button[3];
    public Text[] buttonWayText = new Text[3];

    TEXTSYSTEM textsystem = TEXTSYSTEM.NONE;

    public void Awake()
    {
        instance = this;
    }


    void Start()
    {
        for(int i = 0; i < buttonWay.Length; i++)
        {
            int wayIndex = i;
            butonWay[i].onClick.AddListener(()=> OnwayClick(wayIndex));
        }

        StoryModellint();
        StartCoroutine(ShowText());
    }

    public void StoryModellint()
    {
        fullText = currentStoryModel.storyText;
        storyindex.text = currentStoryModel.storyNumber.ToSrting();

        for(int i = 0; i < currentStoryModel.options.Length; i++)
        {
            buttonWayWayText[i].text = currentStoryModel.options[i].buttonText;
        }
    }

    public void CoShowText()
    {
        StoryModellint();
        ResetShow();
        StartCoroutine (ShowText());

    }

    public void ResetShow()
    {
        textComponent.text = "";

        for(int i = 0; i < buttonWay.Length;i++)
        {
            buttonWay[i].gameObject.SetActive(false);
        }
    }
    IEnumerator ShowText()
    {
        if(currentStoryModel.MainImage != null)
        {
            Rect rect = new Rect(0, 0, currentStoryModel.MainImage.width, currentStoryModel.MainImage.height);
            Vector2 pivot = new Vector2(0.5f, 0.5f);
            Sprite sprite = Sprite.Create(currentStoryModel.MainImage, rect, pivot);

            imageComponet.sprite = sprite;
        }
        else
        {
            debug.LogError("Texture를 가져올 수 없습니다");
        }
        
        for(int i = 0; i <=fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            textComponent.text = currentText;
            yield return WaitForSeconds(delay);
        }
        
        for(int i = 0; i<=currentStoryModel.options.Length; i++)
        {
            buttonWay[i].gameObject.SetActive(true);
            yield return new WaitForSeconds(delay);
        }

        textSystem = TEXTSYSTEM.NONE;
    }
    public void OnwayClick(int index)
    {
        if (textsystem == TEXTSYSTEM.DOING)
            return;

        Debug.Log("OnWayClick : "+ index);

        bool CheckEventTypeNone = false;
        StoryModel playStoryMode = currentStoryModel;

        if (playStoryMode.options[index].eventCheck.type == StoryModel.EventCheck.EventType.NONE)
        {
            for(int i = 0; i < playStoryMode.options[index].eventCheck.successResult.Length; i++)
            {
                GameSystem.Instance.ApplyChoice(currentStoryModel.options[index].eventCheck.successResult[i]);
                CheckEventTypeNone = true;
            }
        }
    }
    

}
