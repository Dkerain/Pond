using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRhythmSync : MonoBehaviour
{
    public GameObject spriteprefab;
    public float sensity = 1f;
    private AudioSource audiosource;
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        float[] spectrumData = new float[256];
        audiosource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);
        float maxFrequency = 0f;
        for(int i=0; i<spectrumData.Length; i++)
        {
            if(spectrumData[i]>maxFrequency)
            {
                maxFrequency = spectrumData[i];
            }
        }
        if(maxFrequency>sensity)
        {
            GenerateSprites();
        }
    }
    void GenerateSprites()
    {
        GameObject sprite = Instantiate(spriteprefab);
        sprite.transform.position = new Vector3(Random.Range(8.5f, -8.5f),Random.Range(2.5f,-2.5f),0);
    }
}
