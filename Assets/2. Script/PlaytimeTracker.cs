using UnityEngine;
using UnityEngine.UI; // UI �ؽ�Ʈ�� ����ϴ� ���

public class PlaytimeTracker : MonoBehaviour
{
    private float playtime = 0f; // �÷���Ÿ�� ���� ����
    public Text playtimeText;    // UI�� ǥ���� �ؽ�Ʈ (���û���)

    // Update is called once per frame
    void Update()
    {
        // �� ������ ��� �ð� ����
        playtime += Time.deltaTime;

        // �÷���Ÿ���� �� ������ �α� ��� (���û���)
        if (playtimeText != null)
        {
            playtimeText.text = $"�÷���Ÿ��: {playtime:F2}��";
        }
    }

    // ���� �÷���Ÿ���� ��ȯ�ϴ� �Լ� (�ʿ��)
    public float GetPlaytime()
    {
        return playtime;
    }
}
