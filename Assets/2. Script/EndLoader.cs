using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Update()
    {
        // ���� Ű �Է� ����
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // "End" �� �ε�
            SceneManager.LoadScene("End");
        }
    }
}