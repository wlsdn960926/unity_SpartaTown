using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : TopDownAnimations
{
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Animation;
    }

    // Update is called once per frame
    public void Animation(Vector2 direction)
    {
        animator.SetBool("IsWalking", direction.magnitude > 0f);
    }
}
