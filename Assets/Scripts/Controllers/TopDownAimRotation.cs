using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _controller;

    // Start is called before the first frame update
    void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        //마우스와 캐릭터사이의 각도를 구해 캐릭터 방향을 조정
    }

}
