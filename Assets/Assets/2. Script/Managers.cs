using UnityEngine;

public class Managers : MonoBehaviour
{
    // 싱글톤 인스턴스를 저장할 정적 변수
    public static Managers Instance { get; private set; }

    private void Awake()
    {
        // 싱글톤 패턴을 구현하기 위해 중복 인스턴스를 방지
        if (Instance == null)
        {
            Instance = this; // 현재 객체를 싱글톤으로 설정
            DontDestroyOnLoad(gameObject); // 씬이 변경되어도 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject); // 중복된 매니저는 삭제
        }
    }
}
