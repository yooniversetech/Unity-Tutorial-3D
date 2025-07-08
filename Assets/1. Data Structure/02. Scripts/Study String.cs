using UnityEngine;

public class StudyString : MonoBehaviour
{
    public string str1 = " lHello Worldl ";

    public string[] str2 = new string[3] { "Hello", "Unity", "World" };

    private void Start()
    {
        Debug.Log(str1[0]);
        Debug.Log(str1[2]);

        Debug.Log(str2[0]);
        Debug.Log(str2[2]);

        Debug.Log(str1.Length); // str1의 문자열 길이
        Debug.Log(str1.Trim()); // 공백제거
        Debug.Log(str1.Trim('l')); // 문자 'l' 제거

        Debug.Log(str1.Contains('H'));
        Debug.Log(str1.Contains('h'));

        Debug.Log(str1.Contains("Hello"));

        Debug.Log(str1.ToUpper());
        Debug.Log(str1.ToLower());

        Debug.Log(str1.Replace("World", "Unity"));

        string text = "Apple, Banana, Orange, Melon, Mandarin, Water Melon, Mango";

        string[] fruits = text.Split(',');

        foreach (var fruit in fruits)
        {
            Debug.Log(fruit);
        }
    }
}
