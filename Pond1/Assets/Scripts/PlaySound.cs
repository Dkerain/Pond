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
            Debug.Log("�Ѳ�������");
        }
        else
        {
            Debug.Log("δ�ҵ�ʵ��");
        }
    }
}
