using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject basisObject;
    public float rotate_speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = basisObject.transform.position;
        //　Rotate MainCamera while left-click
        if(Input.GetMouseButton(0)){
            rotateCameraAngle();
        }
    }

    /*void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");
        rotateCameraAngle();
    }*/

    private void rotateCameraAngle()
    {
        Vector3 angle = new Vector3(
            Input.GetAxis("Mouse X") * rotate_speed,
            Input.GetAxis("Mouse Y") * rotate_speed,
            0
        );
        transform.eulerAngles += new Vector3(-angle.y, angle.x);
    }
}
