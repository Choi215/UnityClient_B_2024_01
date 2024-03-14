using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    public EventChannel eventChannel;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //스페이스바 누를때 이벤트 생성
        {
            eventChannel.RaiseEvent();
        }
    }
}
