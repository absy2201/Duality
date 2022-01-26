using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    private void Update()
    {
        if(GlobalStateController.Instance.State)
        {
            NormalState();
        }
        else
        {
            AbnormalState();
        }
    }

    public virtual void NormalState()
    {
        Debug.Log("I'm doing Normal Stuff!");
    }

    public virtual void AbnormalState()
    {
        Debug.Log("I'm doing Abnormal Stuff!");
    }
}
