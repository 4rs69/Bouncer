using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class RandomSpawnCylinder : MonoBehaviour
{
    [SerializeField]
    private GameObject _cylynder;

    [SerializeField]
    public Color[] _colors;

    [SerializeField]
    private int _countCylynder = 6;

    
    

    private void Start()
    {
        
        var indexColor = 0;

        for (var i = 0; i < _countCylynder; i++)
        {
            if (indexColor >= _colors.Length )
            {
                indexColor = 0;
            }
            
            var cylinderSpawn = Instantiate(_cylynder);
            cylinderSpawn.transform.position = new Vector3(Random.Range(-9, 9), 0.98f, Random.Range(9, -9));
            СolorСhangeСylinder(cylinderSpawn, indexColor);
            indexColor++;
        }
        
    }

    private void СolorСhangeСylinder(GameObject cylynderSpawn, int indexColor)
    {
        
        cylynderSpawn.GetComponent<Renderer>().material.color = _colors[indexColor];
        
    }
    
}
