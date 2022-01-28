using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public bool isHeld;
    public bool EnablePhysicsWhenDropped;

    private Rigidbody rb;
    private Outline outline;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(TryGetComponent<Outline>(out outline))
        {
            outline = GetComponent<Outline>();
        }
        else
        {
            outline = gameObject.AddComponent<Outline>();
        }
        
        InitOutline();
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
        transform.localRotation = Quaternion.identity;

        if (rb != null)
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

    private void InitOutline()
    {
        outline.OutlineColor = Color.red;
        outline.OutlineMode = Outline.Mode.OutlineVisible;
        outline.OutlineWidth = 5f;
    }
}
