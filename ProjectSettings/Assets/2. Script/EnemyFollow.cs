using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Player�� Transform
    public float detectionRange = 10f; // Player�� ������ ����
    public float moveSpeed = 2f; // Enemy�� �̵� �ӵ�

    private bool isPlayerInRange = false;

    void Update()
    {
        // Player�� Enemy �� �Ÿ� ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Player�� ���� ���� ���� �ִ��� Ȯ��
        isPlayerInRange = distanceToPlayer <= detectionRange;

        // Player�� ���� �ȿ� �ִٸ� ����
        if (isPlayerInRange)
        {
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        // Player�� ���� ���� ���
        Vector3 direction = (player.position - transform.position).normalized;

        // Enemy �̵�
        transform.position += direction * moveSpeed * Time.deltaTime;
    }

    // ���� ������ �ð������� �����ֱ� ���� Gizmos ���
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
