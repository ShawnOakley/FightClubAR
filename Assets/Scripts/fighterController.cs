using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighterController : MonoBehaviour {
    public Transform enemyTarget;
    public Animator anim;
    public static bool moveBack = false;
    public static bool moveForward = false;
    public static fighterController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(moveBack == true)
        {
            anim.SetTrigger("walkBack");
            anim.ResetTrigger("idle");
        }
        else
        {
            anim.SetTrigger("idle");
            anim.ResetTrigger("walkBack");
        }

        if(moveForward == true)
        {
            anim.SetTrigger("walkForward");
            anim.ResetTrigger("idle");
        }
        else if (moveBack == false)
        {
            anim.SetTrigger("idle");
            anim.ResetTrigger("walkForward");
        }
	}
}
