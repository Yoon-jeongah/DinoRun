using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_left : MonoBehaviour
{
    public float speed = 1f; //���� * �ӵ�

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    
}
