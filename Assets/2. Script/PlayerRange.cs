using UnityEngine;

public class PlayerRange : MonoBehaviour
{
    public float range = 5f;  // ���� ��
    public KeyCode rangeKey = KeyCode.Z;  // ������ ���� Ű (ZŰ)

    void Update()
    {
        if (Input.GetKeyDown(rangeKey))
        {
            GetRangeValue();
        }
    }

    void GetRangeValue()
    {
        // �÷��̾��� ��ġ
        Vector3 playerPosition = transform.position;

        // ���� ���� ���� ���� ��� (��: ���� ���� ��ǥ�� ���)
        Debug.Log("Player ��ġ: " + playerPosition);
        Debug.Log("���� �� ��ǥ�� ���:");

        // ���÷� ���� ���� ��ǥ�� ���ϴ� ������ ��� (��ü���� ��� ������ ��Ȳ�� �°� ���� ����)
        Vector3 rangeStart = playerPosition - new Vector3(range, range, range);  // ������ ������
        Vector3 rangeEnd = playerPosition + new Vector3(range, range, range);  // ������ ����

        Debug.Log("���� ������: " + rangeStart);
        Debug.Log("���� ����: " + rangeEnd);
    }
}
