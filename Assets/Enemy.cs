using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : PSObject
{
    private Rigidbody2D rd2D;
    private GameObject objPlayer;

    private Vector3 moveDir = Vector3.zero;

    public void Awake()
    {
        objPlayer = GameObject.FindGameObjectWithTag("Player");
        rd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        moveDir = objPlayer.transform.position - transform.position;

        moveDir = moveDir.normalized;

        Quaternion targetQ = Quaternion.LookRotation(Vector3.forward, moveDir);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQ, 360);

        rd2D.MovePosition(rd2D.position + moveSpeed * Time.deltaTime * (Vector2)moveDir);
    }
}
