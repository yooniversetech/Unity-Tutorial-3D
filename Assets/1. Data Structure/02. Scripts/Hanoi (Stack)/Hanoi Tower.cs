using System.Collections;
using TMPro;
using UnityEngine;

public class HanoiTower : MonoBehaviour
{
    public enum HanoiLevel { Lv1 = 3, Lv2, Lv3 }
    public HanoiLevel hanoiLevel;

    public GameObject[] donutPerfabs;
    public Stick[] sticks;

    public TextMeshProUGUI countTextUI;

    public static GameObject selectedDonut;
    public static bool isSelected;
    public static Stick currStick;
    public static int moveCount;

    private IEnumerator Start()
    {
        for (int i = (int)hanoiLevel - 1; i >= 0 ; i--) // 반복문으로 Level만큼 도넛 생성
        {
            GameObject donut = Instantiate(donutPerfabs[i]); // 도넛 생성
            donut.transform.position = new Vector3(-5f, 5f, 0f); // 도넛 생성 위치 : 왼쪽 막대기 + 왼쪽

            sticks[0].PushDonut(donut);

            yield return new WaitForSeconds(1f);// 순차적으로 생성
        }

        moveCount = 0;
        countTextUI.text = moveCount.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currStick.stickStack.Push(selectedDonut);

            isSelected = false;
            selectedDonut = null;
        }
        countTextUI.text = moveCount.ToString();
    }
}
