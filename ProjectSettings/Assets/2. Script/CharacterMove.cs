using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    void Update()
    {
        // 입력 값 받아오기
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // 이동 방향 계산
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        // 플레이어 이동
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
