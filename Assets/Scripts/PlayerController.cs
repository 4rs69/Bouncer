using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Player _player;

    [SerializeField]
    private LayerMask _layer;


    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out var hitInfo, 50f, _layer))
        {
            if (Input.GetMouseButtonDown(1))
            {
                var point = hitInfo.point;
                _player.StartMove(point);
            }
        }
    }
}


