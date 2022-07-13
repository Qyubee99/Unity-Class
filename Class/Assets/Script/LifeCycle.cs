using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    int health;
    private void Awake() // <- ù��°
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
// �ʱ�ȸ : ������ ���۵� �� �� �ѹ��� ȣ��˴ϴ�.
// Awake() : ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� ���� ����Ǵ� �Լ�
// Start() : ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� ���� ����Ǵ� �Լ�
// OnEnable() : ���� ������Ʈ�� Ȱ��ȭ�� ������ ȣ��Ǵ� �Լ�
// Fixed Update : Timestep�� ������ ���� ���� ������ �������� �浹�� ó���ϱ� ���� ������Ʈ �Լ�