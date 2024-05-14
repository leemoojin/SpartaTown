using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   
    //ī�޶� ����ٴ� Ÿ��
    [SerializeField] private GameObject _player;

    private float _cameraSpeed = 5.0f;

    private void FixedUpdate()
    {
       
        Vector3 targetPos = new Vector3(_player.transform.position.x, _player.transform.position.y, this.transform.position.z);
        this.transform.position = targetPos;
    }
}
