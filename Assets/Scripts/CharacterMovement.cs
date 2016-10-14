using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    [SerializeField]private float _speed;
    private bool isMoving;

    public delegate void AnimationDelegate();
    public static AnimationDelegate playAnimation;
    public static AnimationDelegate stopAnimation;

	// Update is called once per frame
	void Update () {

        Move();

        if (isMoving && playAnimation != null)
        {
            playAnimation();
        }
        else
            stopAnimation();

    }

    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            CharacterRotation.RotateRight += Rotate;
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            CharacterRotation.RotateLeft += Rotate;
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);

            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
    }

    void Rotate()
    {

    }
}
