using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rigidbody;
    

    public float speed = 20f;

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    // 로딩
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // 초기 값 설정
    void Start()
    {
    }

    // 
    void Update()
    {
        _rigidbody.velocity = new Vector3(0, 0 ,0);
    }
}