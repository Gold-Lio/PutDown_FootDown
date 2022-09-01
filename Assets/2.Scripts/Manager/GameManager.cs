using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Item 관련 --------------------------------------------------------------------------------
    private ItemDataManager itemData;
    public ItemDataManager ItemData
    {
        get => itemData;
    }
    // ------------------------------------------------------------------------------------------

    // Inven 관련 --------------------------------------------------------------------------------
    private InventoryUI inventoryUI;
    public InventoryUI InvenUI => inventoryUI;
    // ------------------------------------------------------------------------------------------

    // 게임 매니저의 인스턴스 생성
    static GameManager instance = null;

    // 프로퍼티로 게임매니저 인스턴스 접근 (보안 이슈)
    public static GameManager Inst
    {
        get => instance;
    }

    private void Awake()
    {
        // 인스턴스가 null이면 생성
        if (instance == null)
        {
            instance = this;
            instance.Initialize();
            DontDestroyOnLoad(this.gameObject);
        }
        else // 아니라면 현재 인스턴스가 게임매니저인지 확인하고 아니라면 삭제
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    /// <summary>
    /// 게임매니저 초기화 (게임매니저가 재생성될때 Awake가 실행될때 컴포지트를 중복으로 불러올수 있어서 생성
    /// </summary>
    private void Initialize()
    {
    }
}
