using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {

    [Tooltip("The Animator component on this gameobject")]
    public Animator animator;
    [Tooltip("The name of the Animator trigger parameter")]
    public string triggerName;

    public SphereScript()
    {
        animator = new Animator();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpinIt()
    {
        animator.SetTrigger(triggerName);
    }

}
