using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Update()
    {
        // 엔터 키 입력 감지
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // "End" 씬 로드
            SceneManager.LoadScene("End");
        }
    }
}