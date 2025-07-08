using NUnit.Framework;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    public List<int> list1 = new List<int>() { 1, 2, 3 };

    private void Start()
    {
        //list1.Add(10); // 마지막 값에 10 추가

        for (int i = 1; i < 11; i++)
        {
            list1.Add(i);
        }

        list1.Insert(5, 100);

        list1.Remove(5);

        list1.RemoveAt(5);

        list1.RemoveRange(1, 3);

        list1.Clear();

        list1.RemoveAll(x => x > 5);

        // 아래는 한줄로 데이터를 보는 기능
        string str = string.Empty;
        foreach (var x in list1)
        {
            str += x.ToString() + " / ";
        }
        Debug.Log(str);

        if (list1.Contains(10))
            Debug.Log("값 10이 존재 O");
        else
            Debug.Log("값 10이 존재 X");
    }























    //private object[] array = new object[3];

    //void Add(object o)
    //{
    //    var temp = new object[array.Length + 1];

    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        temp[i] = array[i];
    //    }

    //    array = temp;
    //    array[array.Length - 1] = o;
    //}

    //private List<int> list1 = new List<int>();
    //private List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };
    //private List<int> list3; // private일때는 new List<int>()가 없으면 오류 그러나 public 일 때는 없어도 오류가 아님

    //private void Start()
    //{
    //    list1.Add(10);
    //    list2.Add(10);
    //    list3.Add(10);
    //}

}
