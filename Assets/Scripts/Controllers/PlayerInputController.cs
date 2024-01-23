using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim); //main camera���� ���콺 ������ ��ǥ�� ������

        newAim = worldPos - (Vector2)transform.position.normalized; // ���콺 ��ǥ���� Player ��ǥ�� ���� Player���� ���콺���� ������ ����
        CallLookEvent(newAim);
    }
}
