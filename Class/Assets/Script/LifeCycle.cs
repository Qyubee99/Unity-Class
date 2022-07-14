using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Data
{
    // ����
    // �⺻ ���� �����ڴ� private�Դϴ�.
    public int price;
    public string name;
    public Sprite sprite;
    
    // �⺻ ������
    // �����ڸ� �������� ������ �ڵ����� �⺻ �����ڸ� ���������ݴϴ�.

}

public class LifeCycle : MonoBehaviour
{
    // ����Ƽ������ �Ҹ��ڰ� �������� �ʽ��ϴ�.
    public Data[] data; // �迭�� ũ�� (?)

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    private void Awake() // <- ù��°
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
    // ���� ������Ʈ�� ��Ȱ��ȭ�� ������ ȣ��Ǵ� �Լ�
    private void OnDisable()
    {
        Debug.Log("Tiger OnDisable");
    }
    // ���� ������Ʈ�� �ı��Ǵ� ���� ȣ��Ǵ� �Լ�
    private void OnDestroy()
    {
        
    }
}
// �ʱ�ȸ : ������ ���۵� �� �� �ѹ��� ȣ��˴ϴ�.
// Awake() : ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� ���� ����Ǵ� �Լ�
// Start() : ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� ���� ����Ǵ� �Լ�
// OnEnable() : ���� ������Ʈ�� Ȱ��ȭ�� ������ ȣ��Ǵ� �Լ�
// Fixed Update : Timestep�� ������ ���� ���� ������ �������� �浹�� ó���ϱ� ���� ������Ʈ �Լ�