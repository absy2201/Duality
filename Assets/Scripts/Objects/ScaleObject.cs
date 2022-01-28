using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : InteractiveObject
{
    public Vector3 normalScale;
    public Vector3 alernateScale;

    public override void NormalState()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, normalScale, Time.deltaTime);
    }

    public override void AlternateState()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, alernateScale, Time.deltaTime);
    }
}
