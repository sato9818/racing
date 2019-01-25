using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosController : MonoBehaviour
{

    public Transform Camera;
    public Transform Unitychan;
    public Transform Head;

    void Update()
    {
        Unitychan.position = Camera.position - (Head.position - Unitychan.position);
    }
}