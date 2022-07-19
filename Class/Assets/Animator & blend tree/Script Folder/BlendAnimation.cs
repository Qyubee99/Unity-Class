using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        // animator <- Animator component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 수평에 대한 정보          // GetAxis에는 내가 원하는 입력 정보를 넣어주어야 합니다.
        // X축으로 -1 ~ 1 사이의 값을 반환합니다.
        // Left Key를 누르면 -1
        // Right Key를 누르면 1
        float horizontal = Input.GetAxis("Horizontal"); // ← →
        float vertical = Input.GetAxis("Vertical"); // ↑ ↓

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}
