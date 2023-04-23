using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private Rigidbody2D rd2D;

    public void Awake()
    {
        rd2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HMInput.instance.moveDir != Vector3.zero)
        {
            rd2D.MovePosition(rd2D.position + moveSpeed * Time.deltaTime * (Vector2)HMInput.instance.moveDir);
            Quaternion targetQ = Quaternion.LookRotation(Vector3.forward, HMInput.instance.moveDir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQ, 360);
        }
    }
}
