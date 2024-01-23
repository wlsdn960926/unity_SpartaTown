using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public delegate void OnMoveDel(Vector2 direction);
    public OnMoveDel OnMoveEvent;

    public delegate void OnLook(Vector2 direction);
    public OnLook OnLookEvent;
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
