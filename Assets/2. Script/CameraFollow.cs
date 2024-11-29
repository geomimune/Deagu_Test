using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // 따라갈 플레이어
    public Vector3 offset = new Vector3(0, 5, -10); // 플레이어와 카메라 간의 거리

    void LateUpdate()
    {
        // 카메라 위치를 플레이어 위치 + 오프셋으로 설정
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
