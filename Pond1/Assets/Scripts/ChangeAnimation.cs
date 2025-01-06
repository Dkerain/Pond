using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnMouseDown()
    {
        animator.Play("SpreadOutAnimation");
    }
    public void DestroySprites()
    {
        Destroy(gameObject);
    }
}
