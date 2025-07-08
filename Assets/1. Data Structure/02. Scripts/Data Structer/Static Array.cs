using UnityEngine;

public class StaticArray : MonoBehaviour
{
    public int[] arr1; // 배열 선언만
    public int[] arr2 = { 10, 20, 30, 40, 50 }; // 배열 선언과 초기화
    public int[] arr3 = new int[5]; // 배열 선언과 공간만 할당
    public int[] arr4 = new int[5] {10,20,30,40,50}; // 배열 선언과 공간 할당 + 초기화

    NewData[] data = new NewData[5]; // 클래스로 선언된 것은 하나의 타입처럼 사용하여 배열로도 선언 가능

    private void Start()
    {
        int num = arr2[3];//이는 arr2의 4번째 요소의 값을 가지고 와서 num에 대입됨
    }
}

public class NewData
{

}