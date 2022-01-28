using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : InteractiveObject
{
    [SerializeField] private float rotation_angle;
    [SerializeField] private Color normalColor;
    [SerializeField] private Color abnormalColor;

    private Rigidbody ladder;

    private void Start()
    {
        ladder = GetComponent<Rigidbody>();
    }
    public override void NormalState()
    {
        base.NormalState();

        gameObject.GetComponent<MeshRenderer>().material.color = normalColor;
    }

    public override void AlternateState()
    {
        base.AlternateState();

        gameObject.GetComponent<MeshRenderer>().material.color = abnormalColor;
        transform.RotateAround(new Vector3 (0,0,0), Vector3.up, rotation_angle);
    }
}
