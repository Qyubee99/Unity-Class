using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 강체를 가지고 물리적인 이동을 구현하는 방법
public class CharacterControll : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            // AddForce : 객체에 일정한 힘을 가하는 함수
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + direction.normalized * speed * Time.fixedDeltaTime);
    }

    // OnCollisionEnter : 물리적인 충돌을 했을 때 호출되는 함수입니다.
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    // OnCollisionStay : 물리적인 충돌을 하고 있을 때 호출되는 함수입니다.
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // OnCollisionExit : 물리적인 충돌을 벗어났을 때 호출되는 함수입니다.
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
// Collision : 물리적인 충돌을 했을 때 동작하는 함수
// Trigger : 물리적인 연산을 하지 않고 충돌을 처리해주는 함수