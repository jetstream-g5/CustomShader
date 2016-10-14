using UnityEngine;
using System.Collections;

public class SetVertexAmount : MonoBehaviour {

    private Renderer _renderer;
    private float _fatness;
    private float _minFatness = 0f;
    private float _maxFatness = 0.15f;
    public delegate void VertexDelegate();
    public static VertexDelegate AddVertex;
    public static VertexDelegate RemoveVertex;

	// Use this for initialization
	void Start () {
        _renderer = GetComponent<Renderer>();
	}

    void Update()
    {
        if(AddVertex != null && _fatness < _maxFatness)
        {
            ChangeVertex(0.01f);
            AddVertex = null;
        }
        if(RemoveVertex != null && _fatness > _minFatness)
        {
            ChangeVertex(-0.01f);
            RemoveVertex = null;
        }
    }

    void ChangeVertex(float _amount)
    {
        _fatness += _amount;
        _renderer.material.SetFloat("_Extrusion", _fatness);
    }
}
