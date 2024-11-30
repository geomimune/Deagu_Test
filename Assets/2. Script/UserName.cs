using UnityEngine;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{
    public InputField inputField; // InputField ������Ʈ�� ����
    private string savedName; // �Էµ� �ؽ�Ʈ�� ����

    void Start()
    {
        // inputField�� �������� �ʾ����� �α� ���
        if (inputField == null)
        {
            Debug.LogError("InputField�� ������� �ʾҽ��ϴ�. �����Ϳ��� InputField�� �����ϰų� �ڵ����� ã���� �����ϼ���.");
            return;
        }

        // �̺�Ʈ ������ ���
        inputField.onEndEdit.AddListener(OnInputEndEdit);
    }

    private void OnInputEndEdit(string input)
    {
        // ���� Ű�� �Է��� �Ϸ�Ǿ��� ���� ����
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log(input);
        }
    }
    // �Էµ� �ؽ�Ʈ�� �����ϴ� �Լ�
    public void SaveName()
    {
        
        savedName = inputField.text; // InputField�� �ؽ�Ʈ�� ����
        Debug.Log("����� �ؽ�Ʈ: " + savedName);
    }

    // ����� �ؽ�Ʈ ��������
    public string GetSavedName()
    {
        return savedName;
    }
}
