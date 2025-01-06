using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ChangeText : MonoBehaviour,IPointerClickHandler
{
    public Text myText;
    public string newString;
    public string changeScene;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        myText.text = newString;
        Invoke("SwitchScene", 3.0f);
    }
    void SwitchScene()
    {
        SceneManager.LoadScene(changeScene);
    }
}
