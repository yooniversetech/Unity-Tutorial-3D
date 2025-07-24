using System.Collections.Generic;
using UnityEngine;

public class AStarMover : MonoBehaviour
{
    private Transform startPos, endPos;
    public Node startNode, endNode;

    public List<Node> pathList = new List<Node>();

    public GameObject startCube, endCube;

    void Start()
    {
        GetPath();
    }

    void GetPath()
    {
        startPos = startCube.transform;
        endPos = endCube.transform;

        int startIndex = GridManager.Instance.GetGridIndex(startPos.position);
        int startRow = GridManager.Instance.GetRow(startIndex);
        int startCol = GridManager.Instance.GetColumn(startIndex);
        startNode = GridManager.Instance.nodes[startRow, startCol];

        int endIndex = GridManager.Instance.GetGridIndex(endPos.position);
        int endRow = GridManager.Instance.GetRow(endIndex);
        int endCol = GridManager.Instance.GetColumn(endIndex);
        endNode = GridManager.Instance.nodes[endRow, endCol];


        // Start에서 End까지의 방문한 Node List
        pathList = AStar.FindPath(startNode, endNode);
    }

    void OnDrawGizmos()
    {
        if (pathList == null)
            return;

        if (pathList.Count > 0)
        {
            int index = 1;
            foreach (Node node in pathList)
            {
                if (index < pathList.Count)
                {
                    Node nextNode = pathList[index];
                    Debug.DrawLine(node.pos, nextNode.pos, Color.green);
                    index++;
                }
            }
        }
    }
}