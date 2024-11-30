using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toSceneLoader : MonoBehaviour
{
    public Button startButton; // "StartButton"을 연결할 변수

    void Start()
    {
        // 버튼에 OnClick 이벤트 연결
        startButton.onClick.AddListener(LoadSampleScene);
    }

    // SampleScene 로드 함수
    private void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
