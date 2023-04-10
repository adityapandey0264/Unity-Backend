using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main _Instance;
    public DateWeb web;

    // Start is called before the first frame update
    void Start()
    {
        web = GetComponent<DateWeb>();
        _Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
