using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // ���� ��

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        // Rigidbody ������Ʈ ��������
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // �����̽��ٸ� ������, �ٴڿ� ���� ���� ����
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 'ground' ������Ʈ�� �浹���� �� isGrounded�� true�� ����
        if (collision.gameObject.name == "ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // 'ground' ������Ʈ���� ����� isGrounded�� false�� ����
        if (collision.gameObject.name == "ground")
        {
            isGrounded = false;
        }
    }
}
