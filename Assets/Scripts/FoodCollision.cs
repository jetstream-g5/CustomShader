using UnityEngine;
using System.Collections;

public class FoodCollision : MonoBehaviour {

    void OnTriggerEnter()
    {
        Destroy(this.gameObject);
    }
}
