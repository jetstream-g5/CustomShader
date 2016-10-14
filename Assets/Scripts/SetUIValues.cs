using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetUIValues : MonoBehaviour {

    [SerializeField]private Text Fastfood;
    [SerializeField]private Text Weight;
    [SerializeField]private Text Healthyfood;

    [Range(50,140)]
    private int  _weight = 65;

    private int _fastfood;
    private int _healthyFood;

    public delegate void UIDelegate();
    public static UIDelegate AddHealthyFood;
    public static UIDelegate AddFastfood;
	
	// Update is called once per frame
	void Update () {
        ChangeHealthyFood();
        ChangeFastfood();
	}

    void ChangeHealthyFood()
    {
        if(AddHealthyFood != null)
        {
            _healthyFood += 1;
            string healthyFoodString = _healthyFood.ToString();
            Healthyfood.text = healthyFoodString;
            AddHealthyFood = null;
            ChangeWeight(-5);
        }
    }

    void ChangeFastfood()
    {
        if (AddFastfood != null)
        {
            _fastfood += 1;
            string fastfoodString = _fastfood.ToString();
            Fastfood.text = fastfoodString;
            AddFastfood = null;
            ChangeWeight(5);
        }
    }

    void ChangeWeight(int amount)
    {
        _weight = Mathf.Clamp(_weight + amount, 50, 140);
        Weight.text = "Weight: " + _weight;
    }
}
