using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Player의 Transform
    public float detectionRange = 10f; // Player를 감지할 범위
    public float moveSpeed = 2f; // Enemy의 이동 속도

    private bool isPlayerInRange = false;

    void Update()
    {
        // Player와 Enemy 간 거리 계산
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Player가 감지 범위 내에 있는지 확인
        isPlayerInRange = distanceToPlayer <= detectionRange;

        // Player가 범위 안에 있다면 추적
        if (isPlayerInRange)
        {
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        // Player를 향한 방향 계산
        Vector3 direction = (player.position - transform.position).normalized;

        // Enemy 이동
        transform.position += direction * moveSpeed * Time.deltaTime;
    }

    // 감지 범위를 시각적으로 보여주기 위해 Gizmos 사용
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
