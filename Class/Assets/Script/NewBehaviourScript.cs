using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour // <- main()
{
    // �ʵ�
    // ���� ����
    // C# �Ľ�Į ǥ����� ī�� ǥ����� ����մϴ�.
    int health; // <- �ʱ�ȭ�� ���� �ʾƵ� 0�̶�� ������ ����˴ϴ�.

    void Start()
    {
        health = 100;
        Debug.Log(health);
    }

    void Update() // <- ����Ƽ���� �������ִ� �Լ� 
    {
        // ����
    }
}
