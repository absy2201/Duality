using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public bool AlternateState;
    public Color colA;
    public Color colB;

    // Start is called before the first frame update
    void Start()
    {
        AlternateState = GlobalStateController.Instance.AlternateState;
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalStateController.Instance.AlternateState)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = colB;
            return;
        }
        gameObject.GetComponent<MeshRenderer>().material.color = colA;
    }
}
