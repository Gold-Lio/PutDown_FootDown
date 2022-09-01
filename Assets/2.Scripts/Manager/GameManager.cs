using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Item ���� --------------------------------------------------------------------------------
    private ItemDataManager itemData;
    public ItemDataManager ItemData
    {
        get => itemData;
    }
    // ------------------------------------------------------------------------------------------

    // Inven ���� --------------------------------------------------------------------------------
    private InventoryUI inventoryUI;
    public InventoryUI InvenUI => inventoryUI;
    // ------------------------------------------------------------------------------------------

    // ���� �Ŵ����� �ν��Ͻ� ����
    static GameManager instance = null;

    // ������Ƽ�� ���ӸŴ��� �ν��Ͻ� ���� (���� �̽�)
    public static GameManager Inst
    {
        get => instance;
    }

    private void Awake()
    {
        // �ν��Ͻ��� null�̸� ����
        if (instance == null)
        {
            instance = this;
            instance.Initialize();
            DontDestroyOnLoad(this.gameObject);
        }
        else // �ƴ϶�� ���� �ν��Ͻ��� ���ӸŴ������� Ȯ���ϰ� �ƴ϶�� ����
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    /// <summary>
    /// ���ӸŴ��� �ʱ�ȭ (���ӸŴ����� ������ɶ� Awake�� ����ɶ� ������Ʈ�� �ߺ����� �ҷ��ü� �־ ����
    /// </summary>
    private void Initialize()
    {
    }
}
