using UnityEngine;
using System.Collections;

public class IKcontrols : MonoBehaviour {

    private Animator animator;
    public Transform RightHand;

    // Use this for initialization
    void Start()
    { 
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (animator)
        {
            AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("JumpClimb", true);
                animator.MatchTarget(RightHand.position, RightHand.rotation, AvatarTarget.RightHand, new MatchTargetWeightMask(new Vector3(1, 1, 1), 0), animator.GetFloat("MatchStart"), animator.GetFloat("MatchEnd"));
            }
            else {
                animator.SetBool("JumpClimb", false);
                
            }
        }
    }
}
