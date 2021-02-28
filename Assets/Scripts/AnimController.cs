using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    private Animator animator;
    int isWalkingHash;
    int isKickHash;
    int isDancingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isKickHash = Animator.StringToHash("isKick");
        isDancingHash = Animator.StringToHash("isDancing");
    }

    // Update is called once per frame
    void Update()
    {
        bool wPressed = Input.GetKey("w");
        bool dPressed = Input.GetKey("d");
        bool kPressed = Input.GetKey("k");
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isKick = animator.GetBool(isKickHash);
        bool isDancing = animator.GetBool(isDancingHash);

        if (!isWalking && wPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !wPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }
        if(!isWalking && !isKick && kPressed)
        {
            animator.SetBool(isKickHash, true);
        }
        if (!isWalking && isKick && !kPressed)
        {
            animator.SetBool(isKickHash, false);
        }
        if (!isDancing && dPressed)
        {
            animator.SetBool(isDancingHash, true);
        }
        if (isDancing && !dPressed)
        {
            animator.SetBool(isDancingHash, false);
        }
    }
}
