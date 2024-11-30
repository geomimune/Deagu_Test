using UnityEngine;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{
    public InputField inputField; // InputField 컴포넌트를 연결
    private string savedName; // 입력된 텍스트를 저장

    void Start()
    {
        // inputField가 설정되지 않았으면 로그 출력
        if (inputField == null)
        {
            Debug.LogError("InputField가 연결되지 않았습니다. 에디터에서 InputField를 설정하거나 자동으로 찾도록 수정하세요.");
            return;
        }

        // 이벤트 리스너 등록
        inputField.onEndEdit.AddListener(OnInputEndEdit);
    }

    private void OnInputEndEdit(string input)
    {
        // 엔터 키로 입력이 완료되었을 때만 저장
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log(input);
        }
    }
    // 입력된 텍스트를 저장하는 함수
    public void SaveName()
    {
        
        savedName = inputField.text; // InputField의 텍스트를 저장
        Debug.Log("저장된 텍스트: " + savedName);
    }

    // 저장된 텍스트 가져오기
    public string GetSavedName()
    {
        return savedName;
    }
}
