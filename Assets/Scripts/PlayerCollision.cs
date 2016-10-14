using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fastfood")
        {
            SetVertexAmount.AddVertex += FillDelegate;
            //fastfood amount +1
            SetUIValues.AddFastfood += FillDelegate;
            //weight + 5
        }
        else if(other.gameObject.tag == "Healthyfood")
        {
            SetVertexAmount.RemoveVertex += FillDelegate;
            //healthy food amount +1
            SetUIValues.AddHealthyFood += FillDelegate;
            //weight - 5
        }
    }

    void FillDelegate()
    {
        
    }
}
