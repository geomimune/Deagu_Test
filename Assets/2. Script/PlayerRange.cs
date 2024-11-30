using UnityEngine;

public class PlayerRange : MonoBehaviour
{
    public float range = 5f;  // 범위 값
    public KeyCode rangeKey = KeyCode.Z;  // 범위를 얻을 키 (Z키)

    void Update()
    {
        if (Input.GetKeyDown(rangeKey))
        {
            GetRangeValue();
        }
    }

    void GetRangeValue()
    {
        // 플레이어의 위치
        Vector3 playerPosition = transform.position;

        // 범위 내에 얻을 값을 출력 (예: 범위 내의 좌표들 출력)
        Debug.Log("Player 위치: " + playerPosition);
        Debug.Log("범위 내 좌표들 계산:");

        // 예시로 범위 내의 좌표를 구하는 간단한 방법 (구체적인 계산 로직은 상황에 맞게 변경 가능)
        Vector3 rangeStart = playerPosition - new Vector3(range, range, range);  // 범위의 시작점
        Vector3 rangeEnd = playerPosition + new Vector3(range, range, range);  // 범위의 끝점

        Debug.Log("범위 시작점: " + rangeStart);
        Debug.Log("범위 끝점: " + rangeEnd);
    }
}
