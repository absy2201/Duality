using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public bool isHeld;
    public bool EnablePhysicsWhenDropped;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(GlobalStateController.Instance.State)
        {
            NormalState();
        }
        else
        {
            AlternateState();
        }
    }

    public virtual void NormalState()
    {
        //Debug.Log("I'm doing Normal Stuff!");
    }

    public virtual void AlternateState()
    {
        //Debug.Log("I'm doing Abnormal Stuff!");
    }

    public void Held(Transform parent, Vector3 position)
    {
        isHeld = true;
        transform.parent = parent;
        transform.position = position;
        transform.rotation = Quaternion.identity;

        rb.isKinematic = true;
    }

    public void Dropped()
    {
        isHeld = false;

        transform.parent = null;

        if (EnablePhysicsWhenDropped && rb != null)
        {
            rb.isKinematic = false;
        }
    }
}
