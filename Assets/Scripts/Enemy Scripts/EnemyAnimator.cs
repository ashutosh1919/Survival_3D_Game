using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour {

    private Animator anim;



	// Use this for initialization
	void Awake () {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    public void Walk(bool walk) {
        anim.SetBool(AnimationTags.WALK_PARAMETER, walk);
	}

    public void Run(bool run)
    {
        anim.SetBool(AnimationTags.RUN_PARAMETER, run);
    }

    public void Attack()
    {
        anim.SetTrigger(AnimationTags.ATTACK_TRIGGER);
    }

    public void Dead()
    {
        anim.SetTrigger(AnimationTags.DEAD_TRIGGER);
    }

} //class
