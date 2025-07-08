using System.Collections.Generic;
using UnityEngine;

public class StudyLinkedList : MonoBehaviour
{
    public LinkedList<int> linkedList1 = new LinkedList<int>();

    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            linkedList1.AddLast(i);
        }

        linkedList1.AddFirst(100);
        linkedList1.AddLast(500);

        var node = linkedList1.AddFirst(1);

        linkedList1.AddBefore(node, 200);

    }
}
