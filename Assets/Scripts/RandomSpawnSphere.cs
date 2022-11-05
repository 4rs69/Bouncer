using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawnSphere : MonoBehaviour
{

    [SerializeField]
    private GameObject _sphere;

    private RandomSpawnCylinder _color;

    private int _randomNumber;

    private void Start()
    {
        _color = FindObjectOfType<RandomSpawnCylinder>();
        _randomNumber = Random.Range(0, 3);
        
        var sphereSpawn = Instantiate(_sphere);
        sphereSpawn.transform.position = new Vector3(Random.Range(-9, 9), 0.5f, Random.Range(9, -9));
        СolorСhangeSphere(sphereSpawn, _randomNumber);


    }
    private void СolorСhangeSphere(GameObject cylynderSpawn, int randomNumber)
    {
        cylynderSpawn.GetComponent<Renderer>().material.color = _color._colors[randomNumber];
    }
    

}
