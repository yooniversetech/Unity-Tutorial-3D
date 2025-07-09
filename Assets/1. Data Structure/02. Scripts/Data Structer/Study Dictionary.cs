using System.Collections.Generic;
using UnityEngine;

public class PersonData
{
    public int age;
    public string name;
    public float height;
    public float weight;

    public PersonData(int age, string name, float height, float weight)
    {
        this.age = age;
        this.name = name;
        this.height = height;
        this.weight = weight;
    }
}

public class Dictionary : MonoBehaviour
{
    public Dictionary<string, PersonData> persons = new Dictionary<string, PersonData>();

    private void Start()
    {
        persons.Add("철수", new PersonData(10, "철수", 150f, 30f));
        persons.Add("영희", new PersonData(10, "영희", 150f, 30f));
        persons.Add("동수", new PersonData(10, "동수", 150f, 30f));

        Debug.Log(persons["철수"].age);
        Debug.Log(persons["철수"].name);
        Debug.Log(persons["철수"].height);
        Debug.Log(persons["철수"].weight);
    }







    //persons.Add("철수", 10);
    //persons.Add("영희", 15);
    //persons.Add("동수", 17);

    //int age = persons["철수"];
    //Debug.Log($"철수의 나이는{age} 입니두");

    ////string name = persons[10];

    //foreach (var person in persons)
    //{
    //    if (person.Value == 15)
    //    {
    //        Debug.Log($"나이가 15살인 사람의 이름은 {person.Key}입니다.");
    //        Debug.Log($"{person.Key}의 나이는 {person.Value}입니다.");
    //    }
    //}

    //if (persons.ContainsKey("철수"))
    //{
    //    Debug.Log("사람중에 철수가 있다");
    //}

    //if (persons.ContainsValue(17))
    //{
    //    Debug.Log("사람중에 17살이 있다");
    //}
}
