using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SphereCollisionController : MonoBehaviour
{
   [SerializeField]
   private GameObject _sphere;

   [SerializeField]
   private GameObject _palyer;
   
   private RandomSpawnCylinder _color;
   
   private int _randomNumber;
   

   private void OnCollisionEnter(Collision collision)
   {
      
      Destroy(gameObject);
      
      _randomNumber = Random.Range(0, 3);
      
      var sphereSpawn = Instantiate(_sphere);
      sphereSpawn.transform.position = new Vector3(Random.Range(-9, 9), 0.5f, Random.Range(9, -9));
      
      _color = FindObjectOfType<RandomSpawnCylinder>();
      _palyer = FindObjectOfType<GameObject>();
      
      СolorСhangeSphere(sphereSpawn,_randomNumber,collision.gameObject);
   }
   private void СolorСhangeSphere(GameObject cylynderSpawn,int randomNumber,GameObject _player)
   {
      _player.GetComponent<Renderer>().material.color = cylynderSpawn.GetComponent<Renderer>().material.color;
      cylynderSpawn.GetComponent<Renderer>().material.color = _color._colors[randomNumber];
   }
}
