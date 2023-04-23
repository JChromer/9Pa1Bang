using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMInput : MonoBehaviour
{
    public static HMInput instance = null;

    private Vector2 startPoint = Vector2.zero;
    public Vector3 moveDir = Vector3.zero;
    public float force = 0f;

    public void Awake()
    {
        if(instance == null)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPoint = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            moveDir = (Input.mousePosition - (Vector3)startPoint).normalized;
        }

        if (Input.GetMouseButtonUp(0))
        {
            startPoint = Vector2.zero;
            moveDir = Vector3.zero;
        }
    }
}
