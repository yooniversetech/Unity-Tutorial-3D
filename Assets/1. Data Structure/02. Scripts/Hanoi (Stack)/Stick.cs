using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public enum StickType { Left, Center, Right };
    public StickType stickType;

    public Stack<GameObject> stickStack = new Stack<GameObject>();

    private void OnMouseDown()
    {
        if (HanoiTower.isSelected)
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else
        {
            PushDonut(HanoiTower.selectedDonut);
        }
    }

    public bool CheckDonut(GameObject donut)
    {
        if (stickStack.Count > 0)
        {
            int pushNumber = donut.GetComponent<Donut>().donutNumber;

            GameObject peekDonut = stickStack.Peek();
            int peekNumber = peekDonut.GetComponent<Donut>().donutNumber;

            if (pushNumber < peekNumber)
            {
                return true;
            }
            else
            {
                Debug.Log($"");
                return false;
            }
        }

        return true;
    }
    public void PushDonut(GameObject donut)
    {
        if (!CheckDonut(donut))
            return;

        HanoiTower.isSelected = false;
        HanoiTower.selectedDonut = null;

        donut.transform.position = transform.position + Vector3.up * 5f;
        donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        stickStack.Push(donut); // Stack에 Gameobject를 넣는 기능
    }

    public GameObject PopDonut()
    {
        GameObject donut = stickStack.Pop(); // Stack에서 Gameobject를 꺼내는 기능

        return donut; // 꺼낸 도넛을 반환
    }
}
