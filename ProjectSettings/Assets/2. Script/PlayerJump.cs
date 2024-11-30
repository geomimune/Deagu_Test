using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // 점프 힘

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        // Rigidbody 컴포넌트 가져오기
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 스페이스바를 눌렀고, 바닥에 있을 때만 점프
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 'ground' 오브젝트와 충돌했을 때 isGrounded를 true로 설정
        if (collision.gameObject.name == "ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // 'ground' 오브젝트에서 벗어나면 isGrounded를 false로 설정
        if (collision.gameObject.name == "ground")
        {
            isGrounded = false;
        }
    }
}
