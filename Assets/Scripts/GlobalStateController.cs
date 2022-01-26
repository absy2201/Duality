using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStateController : MonoBehaviour
{
    public static GlobalStateController Instance { get; private set; }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private bool state = false;
    public bool State { get { return state; } set { state = value; } }

    private bool menuOpen;
    public bool MenuOpen { get { return menuOpen; } set { menuOpen = value; } }
    
    public GameObject Menu;

    private void Update()
    {
        if(menuOpen)
        {

        }
    }
}
