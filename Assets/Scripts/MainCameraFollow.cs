using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraFollow: MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);    // ��ǥ��
    private float smoothTime = 0.10f;    // �ε巴�� �����̱� ���� �ð�
    private Vector3 velocity = Vector3.zero;   // �ӵ�

    [SerializeField] private Transform target;    // target�� �����ϵ��� ��.

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;                      // Ÿ�� �������� 
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);  // smoothDamp = õõ�� �����̵��� �ϴ� �Լ�! �� ��ġ ��ǥ, Ÿ�� ��ǥ, �� �ӵ��� ref��, �ε巴�� �����̱� ���� �ð�.
    }
    // Start is called before the first frame update
}
