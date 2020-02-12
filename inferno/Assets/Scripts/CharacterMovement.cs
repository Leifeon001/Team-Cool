using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController Char;
    public float speed;
    Vector3 MoveDir;
    public float gravity = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Char = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        MoveDir = transform.TransformDirection(transform.forward);
        MoveDir.y -= gravity * Time.deltaTime;
        Char.Move((MoveDir * speed) * Time.deltaTime);
    }
}
