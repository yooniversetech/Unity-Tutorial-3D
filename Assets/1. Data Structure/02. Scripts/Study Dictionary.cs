using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public Dictionary<string, int> persons = new Dictionary<string, int>();

    private void Start()
    {
        persons.Add("철수", 10);
        persons.Add("영희", 15);
        persons.Add("동수", 17);

        int age = persons["철수"];
        Debug.Log($"철수의 나이는{age} 입니두");

        //string name = persons[10];

        foreach (var person in persons)
        {
            if (person.Value == 15)
            {
                Debug.Log($"나이가 15살인 사람의 이름은 {person.Key}입니다.");
                Debug.Log($"{person.Key}의 나이는 {person.Value}입니다.");
            }
        }

        if (persons.ContainsKey("철수"))
        {
            Debug.Log("사람중에 철수가 있다");
        }

        if (persons.ContainsValue(17))
        {
            Debug.Log("사람중에 17살이 있다");
        }
    }
}
