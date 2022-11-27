using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public Material[] materialSet = new Material[2];
    private int material_num = 0;   // 0 -> default, 1 -> selected
    private bool filled_flag = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor(){
        material_num = 1 - material_num;
        gameObject.GetComponent<MeshRenderer>().material = materialSet[material_num];
    }

    public bool isSelected()
    {
        return material_num == 1;
    }

    public bool isFilled()
    {
        return filled_flag;
    }

    public void switchFilledFlag()
    {
        filled_flag = !filled_flag;
    }

    public void setBall(){
        GameObject new_ball = (GameObject)Resources.Load("Ball");
        Instantiate(new_ball, this.transform.position, Quaternion.identity, this.transform);
        switchFilledFlag();
    }
}
