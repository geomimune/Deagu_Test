using UnityEngine;

public class Managers : MonoBehaviour
{
    // �̱��� �ν��Ͻ��� ������ ���� ����
    public static Managers Instance { get; private set; }

    private void Awake()
    {
        // �̱��� ������ �����ϱ� ���� �ߺ� �ν��Ͻ��� ����
        if (Instance == null)
        {
            Instance = this; // ���� ��ü�� �̱������� ����
            DontDestroyOnLoad(gameObject); // ���� ����Ǿ �ı����� �ʵ��� ����
        }
        else
        {
            Destroy(gameObject); // �ߺ��� �Ŵ����� ����
        }
    }
}
