using UnityEngine;
using UnityEngine.UI; // UI 텍스트를 사용하는 경우

public class PlaytimeTracker : MonoBehaviour
{
    private float playtime = 0f; // 플레이타임 누적 변수
    public Text playtimeText;    // UI에 표시할 텍스트 (선택사항)

    // Update is called once per frame
    void Update()
    {
        // 매 프레임 경과 시간 누적
        playtime += Time.deltaTime;

        // 플레이타임을 초 단위로 로그 출력 (선택사항)
        if (playtimeText != null)
        {
            playtimeText.text = $"플레이타임: {playtime:F2}초";
        }
    }

    // 현재 플레이타임을 반환하는 함수 (필요시)
    public float GetPlaytime()
    {
        return playtime;
    }
}
