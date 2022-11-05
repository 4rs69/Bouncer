using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float _speed = 50f;

    [SerializeField]
    private Rigidbody _rigidbody;

    private Vector3 _target;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    public void StartMove(Vector3 target)
    {
        _target = target;
         var _result = (_target - transform.position).normalized;
        _rigidbody.AddForce(new Vector3(_result.x, 0, _result.z) * _speed);
    }
}
