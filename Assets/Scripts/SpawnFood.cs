using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {

    [SerializeField]private GameObject[] _spawnPoints;
    [SerializeField]private GameObject[] _foods;
	
	// Update is called once per frame
	void Start () {
        StartCoroutine(CreateFood(0.5f));
	}

    IEnumerator CreateFood(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Instantiate(_foods[RandomNumber(0, _foods.Length)], _spawnPoints[RandomNumber(0, _spawnPoints.Length)].transform.position, Quaternion.identity);
        }
    }

    int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}
