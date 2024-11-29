using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�

    void Update()
    {
        // �Է� �� �޾ƿ���
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // �̵� ���� ���
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        // �÷��̾� �̵�
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
