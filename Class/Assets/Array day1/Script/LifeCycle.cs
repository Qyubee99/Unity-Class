using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Data
{
    // 변수
    // 기본 접근 지정자는 private입니다.
    public int price;
    public string name;
    public Sprite sprite;
    
    // 기본 생성자
    // 생성자를 선언하지 않으면 자동으로 기본 생성자를 생성시켜줍니다.

}

public class LifeCycle : MonoBehaviour
{
    // 유니티에서는 소멸자가 존재하지 않습니다.
    public Data[] data; // 배열의 크기 (?)

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    private void Awake() // <- 첫번째
    { 
        for(int i = 0; i < data.Length; i++)
        {
            // 0 <--------- 0
            priceUI[i].text = data[i].price.ToString();
            nameUI[i].text = data[i].name;
            spriteUI[i].sprite = data[i].sprite;
        }
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
    
    }
    // 게임 오브젝트가 비활성화될 때마다 호출되는 함수
    private void OnDisable()
    {
        Debug.Log("Tiger OnDisable");
    }
    // 게임 오브젝트가 파괴되는 순간 호출되는 함수
    private void OnDestroy()
    {
        
    }
}
// 초기회 : 게임이 실핼될 때 단 한번만 호출됩니다.
// Awake() : 게임 오브젝트가 비활성화되었을 때도 실행되는 함수
// Start() : 게임 오브젝트가 활성화되었을 때만 실행되는 함수
// OnEnable() : 게임 오브젝트가 활성화될 때마다 호출되는 함수
// Fixed Update : Timestep의 설정된 값에 따라 일정한 간격으로 충돌을 처리하기 위한 업데이트 함수