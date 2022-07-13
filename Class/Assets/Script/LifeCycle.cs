using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    int health;
    private void Awake() // <- 첫번째
    {
        Debug.Log("Tiger Awake");
    }
    void Start()
    {
        Debug.Log("Tiger Start");
    }
    private void OnEnable()
    {
        Debug.Log("Tiger OnEnable");
    }
    private void FixedUpdate()
    {
        Debug.Log("Tiger FixedUpdate");
    }
    private void Update()
    {
        health++;
        Debug.Log(health);

        if(health >= 100)
        {
            health = 0;
        }
    }
}
// 초기회 : 게임이 실핼될 때 단 한번만 호출됩니다.
// Awake() : 게임 오브젝트가 비활성화되었을 때도 실행되는 함수
// Start() : 게임 오브젝트가 활성화되었을 때만 실행되는 함수
// OnEnable() : 게임 오브젝트가 활성화될 때마다 호출되는 함수
// Fixed Update : Timestep의 설정된 값에 따라 일정한 간격으로 충돌을 처리하기 위한 업데이트 함수