using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldScript : MonoBehaviour
{
    public GameObject[,,] buttons = new GameObject[3,3,3];
    public GameObject originBlock;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Instantiate(originBlock, new Vector3(50.0f*i, 50.0f*j, 50.0f*k), Quaternion.identity);    
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
