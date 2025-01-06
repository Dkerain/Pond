using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesGenerator : MonoBehaviour
{
    public GameObject spriteperfab;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }
    private void Update()
    {
        if(audioSource.isPlaying&&Mathf.Repeat(Time.time,1f)<0.1f)
        {
            GenerateSprites();
        }
    }
    void GenerateSprites()
    {
        GameObject sprite = Instantiate(spriteperfab);
        sprite.transform.position = new Vector3(Random.Range(5f, -5f), Random.Range(5f, -5f), 0);
    }
}
