using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnInCenterWhenPouring : MonoBehaviour
{
   [SerializeField]
   private GameObject _player;

   private void OnCollisionEnter(Collision collision)
   {
      _player.transform.position = new Vector3(0, 0.5f, 0);
   }
}
