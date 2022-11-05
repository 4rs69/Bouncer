using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerCollisionController : MonoBehaviour
{ 
    [SerializeField] 
    private Renderer _renderer;

    [SerializeField]
    private GameObject _cylindder;
    
   private void Start()
   {
       _renderer = GetComponent<Renderer>();
   }
   private void OnCollisionEnter(Collision collision)
   {
       var cylinderColor = collision.gameObject.GetComponent<Renderer>().material.color;
       var playerColor = _renderer.material.color;
       
       if (cylinderColor == playerColor)
       {
           Destroy(collision.gameObject);
       }
   }
}