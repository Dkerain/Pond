using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private void OnMouseDown()
    {
        if(AudioManager.instance!=null)
        {
            AudioManager.instance.Play("Ding");
            Debug.Log("已播放音乐");
        }
        else
        {
            Debug.Log("未找到实例");
        }
    }
}
