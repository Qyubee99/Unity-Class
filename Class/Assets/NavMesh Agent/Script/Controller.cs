using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // 헤더 선언

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // P               =      Po     +     V*t
        //   자기위치                           V = 벡터 t = 시간
        // transform.position = new Vector3(0, 1, 0) * Time.deltaTime;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // RaycastHit : 광선과 충돌한 오브젝트의 물체에 대한 정보를 저장합니다.
            RaycastHit hit;

            // 카메라로부터 스크린 공간의 마우스 포인터를 통해 위치 정보를 설정합니다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // out : 출력용 매개변수
            // 읽기 전용 매개변수입니다.
            // 충돌한 물체가 있다면 Move 함수의 매개변수에 충돌한 오브젝트의 위치를 설정합니다.
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Move(hit.point);
            }
        }
    }

    public void Move(Vector3 Position)
    {
        agent.speed = speed;
        agent.SetDestination(Position);
    }
}
// F = ma
// F : 힘 m : 질량  a : 가속도