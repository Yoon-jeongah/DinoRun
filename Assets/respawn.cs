using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //������Ʈ�� x�� Ư�� ��ġ�� �������� �� ���� ��ġ�� �ǵ�����.
        if (transform.position.x < -12)
        {
            transform.position = new Vector3(12, transform.position.y, transform.position.z);
        }
    }
}
