﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{

    public bool show = false;
    [SerializeField] private GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        show = true;
    }

    private void OnMouseExit()
    {
        show = false;
    }

    private void OnGUI()
    {
        if (show)
        {
            GUI.Label(new Rect(10, 10, 200, 30), "yeet");
        }
    }
}
