using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    [Header("����")]
    public Rigidbody2D rigid;
    [Header("����")]
    public float jumpPower = 1f;
    public float groundCheckDistance = 1f;
    public LayerMask groundLayer;
    private bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        // ����Ƽ Ű���� �����̽��ٸ� �Է¹޾��� �� - ����
        // rigid�� �ִ� AddForce Vector.up �����Ѵ�.

        isGrounded = Physics2D.Raycast(transform.position, 
            Vector2.down, groundCheckDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.AddForce(jumpPower * Vector2.up, ForceMode2D.Impulse);
        }
    }

    
}
