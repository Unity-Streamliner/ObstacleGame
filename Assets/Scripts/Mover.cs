using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] private float _xValue = 0.01f;
    [SerializeField] private float _yValue = 0.0f;
    [SerializeField] private float _zValue = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_xValue, _yValue, _zValue);
    }
    
}
