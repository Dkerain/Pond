using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnimation : MonoBehaviour
{
    public GameObject gameobject;
    private void Start()
    {
        Destroy(gameobject);
    }
}
