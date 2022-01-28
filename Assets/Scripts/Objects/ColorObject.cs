﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : InteractiveObject
{
    [SerializeField] private Color normalColor;
    [SerializeField] private Color abnormalColor;

    private Rigidbody rb;

    public override void NormalState()
    {
        base.NormalState();

        gameObject.GetComponent<MeshRenderer>().material.color = normalColor;
    }

    public override void AlternateState()
    {
        base.AlternateState();

        gameObject.GetComponent<MeshRenderer>().material.color = abnormalColor;


    }
}
