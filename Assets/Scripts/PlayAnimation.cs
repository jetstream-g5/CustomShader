using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
    void OnEnable()
    {
        CharacterMovement.playAnimation += PlayAnim;
        CharacterMovement.stopAnimation += StopAnim;
    }

    void OnDisable()
    {
        CharacterMovement.playAnimation -= PlayAnim;
    }

    void PlayAnim()
    {
        anim.SetBool("IsMoving", true);
    }

    void StopAnim()
    {
        anim.SetBool("IsMoving", false);
    }
}
