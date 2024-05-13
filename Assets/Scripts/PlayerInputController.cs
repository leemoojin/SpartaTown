using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    //lookMouse
    private Camera _camera;

    private Vector2 newAim;
    private Vector2 worldPos;

    private void Awake()
    {
        _camera = Camera.main;
    }

    

    //Input
    public void OnMove(InputValue value)
    {
        //Debug.Log($"PlayerInputController, OnMove value: {value}");
        Vector2 moveInput = value.Get<Vector2>().normalized;
        //Debug.Log($"PlayerInputController, OnMove moveInput: {moveInput}");

        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value) 
    {
        Debug.Log("PlayerInputController.cs - OnLook() - 호출");

        newAim = value.Get<Vector2>();
        worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = worldPos - ((Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }

}
