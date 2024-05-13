using System;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{   
    //플레이어 이미지
    [SerializeField] private SpriteRenderer _characterRenderer;

    private TopDownController _controller;

    private void Awake()
    {
        //_controller = GetComponent<TopDownController>();
        if (!TryGetComponent<TopDownController>(out _controller))
        {
            Debug.Log("TopDownAimRotation.cs - Awake() - _controller 참조 실패");
        }

    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateChar(direction);
    }

    private void RotateChar(Vector2 direction)
    {
        float roZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        _characterRenderer.flipX = Math.Abs(roZ) > 90f;
    }
}
