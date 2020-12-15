﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent agent;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
}
