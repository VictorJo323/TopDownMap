using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraFollow: MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);    // 좌표값
    private float smoothTime = 0.10f;    // 부드럽게 움직이기 위한 시간
    private Vector3 velocity = Vector3.zero;   // 속도

    [SerializeField] private Transform target;    // target을 설정하도록 함.

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;                      // 타겟 포지션이 
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);  // smoothDamp = 천천히 움직이도록 하는 함수! 현 위치 좌표, 타겟 좌표, 현 속도를 ref로, 부드럽게 움직이기 위한 시간.
    }
    // Start is called before the first frame update
}
