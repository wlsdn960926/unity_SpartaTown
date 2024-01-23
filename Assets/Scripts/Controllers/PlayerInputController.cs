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
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim); //main camera에서 마우스 포인터 좌표를 가져옴

        newAim = worldPos - (Vector2)transform.position.normalized; // 마우스 좌표에서 Player 좌표를 빼면 Player에서 마우스로의 방향이 나옴
        CallLookEvent(newAim);
    }
}
