using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KKH_Player_Test : MonoBehaviour
{
    private float dropRange = 2.0f;

    private Player_Test_Input inputActions;

    private Vector3 inputDir = Vector3.zero;

    public float moveSpeed = 3.0f;
    private Rigidbody rigidbody;

    private Inventory inven;

    private void Awake()
    {
        inputActions = new Player_Test_Input();
        rigidbody = GetComponent<Rigidbody>();
        inven = new Inventory();
    }

    private void Start()
    {
        GameManager.Inst.InvenUI.InitializeInventory(inven);
        inven.AddItem(ItemIDCode.Test_Item);        // 테스트 소스

    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Move.performed += OnMove;
        inputActions.Player.Move.canceled += OnMove;
        inputActions.ShortCut.Enable();
        inputActions.ShortCut.InventoryOnOff.performed += OnInventoryOnOff;
    }
    private void OnDisable()
    {
        inputActions.ShortCut.InventoryOnOff.performed -= OnInventoryOnOff;
        inputActions.ShortCut.Disable();
        inputActions.Player.Move.canceled -= OnMove;
        inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Disable();
    }

    private void Update()
    {
        // 이동 입력 확인
        if (inputDir.sqrMagnitude > 0.0f)
        {
            // 설정한 이동속도에 맞춰 캐릭터 이동
            rigidbody.transform.position += moveSpeed * Time.deltaTime * inputDir;
        }
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();

        inputDir.x = input.x;   // 오른쪽 왼쪽
        inputDir.y = 0.0f;
        inputDir.z = input.y;   // 앞 뒤
        //inputDir.Normalize();

        // 입력으로 들어온 값이 있는지 확인
        if (inputDir.sqrMagnitude > 0.0f)
        {
            // 카메라의 y축 회전만 따로 분리해서 inputDir에 적용
            inputDir = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0) * inputDir;
        }
    }
    private void OnInventoryOnOff(InputAction.CallbackContext _)
    {
        GameManager.Inst.InvenUI.InventoryOnOffSwitch();
    }


    public Vector3 ItemDropPosition(Vector3 inputPos)
    {
        Vector3 result = Vector3.zero;
        Vector3 toInputPos = inputPos - transform.position;
        if (toInputPos.sqrMagnitude > dropRange * dropRange)
        {
            result = transform.position + toInputPos.normalized * dropRange;
        }
        else
        {
            result = inputPos;
        }

        return result;
    }
}
