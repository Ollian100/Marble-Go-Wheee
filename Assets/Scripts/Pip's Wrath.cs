using System;
using System.Buffers;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

public class PipsWrath : MonoBehaviour
{
    private Rigidbody2D rb;
    private float Wait = 1000000000f;
    private float Cooldown = 0f;
    private int Target = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MarbleControls.Win == false)
        {
            Wait = Wait - 0.1f;
        }
        if (Wait < 1f)
        {
            
            int Target = UnityEngine.Random.Range(0, 5);
            if (Target == 0)
            {
                Wait = 5f;
            }
            if (Target == 1)
            {
                BroadcastMessage("OOF1");               
            }
            if (Target == 2)
            {
                BroadcastMessage("OOF2");
                
            }
            if (Target == 3)
            {
                BroadcastMessage("OOF3");
                
            }
            if (Target == 4)
            {
                BroadcastMessage("OOF4");
                
            }
            if (Target == 5)
            {
            }
        }
    
}
}