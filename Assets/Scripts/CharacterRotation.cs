using UnityEngine;
using System.Collections;

public class CharacterRotation : MonoBehaviour {

    //private bool _rotateBack;

    private Quaternion _right = Quaternion.Euler(0, 90, 0);
    private Quaternion _left = Quaternion.Euler(0, -90, 0);

    public delegate void RotationDelegate();
    public static RotationDelegate RotateRight;
    public static RotationDelegate RotateLeft;
    public static RotationDelegate RotateForward;
	
	// Update is called once per frame
	void Update () {
        if (RotateLeft != null)
        {
            transform.rotation = _left;
            RotateLeft = null;
           // _rotateBack = false;
        }
        else if (RotateRight != null)
        {
            transform.rotation = _right;
            RotateRight = null;
           // _rotateBack = false;
        }
	}
}
