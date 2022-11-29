using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public ChildBlocks[] blocks = new ChildBlocks[3];
    public int axis; // 0 -> x, 1 -> y, 2 -> z;
    public int num; // 何列目を動かすか. [0, 3)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotate(){

    }
}

[System.Serializable]
public class ChildBlocks
{
    public GameObject[] childBlocks = new GameObject[3];
}