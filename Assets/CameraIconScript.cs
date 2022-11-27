using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraIconScript : MonoBehaviour
{
    public GameObject targetController;
    public GameObject centerButton;
    public GameObject targetPanel;
    public double radius;

    private float center_x;
    private float center_y;
    private float panel_width;
    private float panel_height;
    

    // Start is called before the first frame update
    void Start()
    {
        // this.transform.parent = centerButton.transform;
        center_x = centerButton.transform.position.x;
        center_y = centerButton.transform.position.y;
        panel_width = targetPanel.transform.lossyScale.x;
        panel_height = targetPanel.transform.lossyScale.x;

        // Debug.Log("center_x\t" + center_x);
        // Debug.Log("panel_width\t" + panel_width);
    }

    // Update is called once per frame
    void Update()
    {
        setIconPosition();
    }

    void setIconPosition()
    {

        // カメラの回転角(yのみで十分)
        float camera_y = targetController.transform.localEulerAngles.y;
        // アイコンを傾ける角度
        float angle = - camera_y;
        this.transform.eulerAngles = new Vector3(0, 0, angle);

        // カメラの移動
        // |x|^k + |y|^k = r^k の上を動く
        double pos_x, pos_y;
        (pos_x, pos_y) = getIconPosition(angle, radius);
        this.transform.localPosition = new Vector3((float)pos_x, (float)pos_y, 0.0f);
    }

    (double, double) getIconPosition(float angle, double radius, float k=4.2f)
    {
        double res_x, res_y;
        // tanの発散を防ぐ and 符号の処理のために角度のまずpi/2で分割する
        // angleを[0,2pi)に収める
        angle = 90 - angle;
        while(angle < 0) angle += 360;
        while(angle > 360) angle -= 360;
        int half_pi_num = (int)(angle / 90);
        double sub_angle = angle - half_pi_num * 90;
        bool  greater_than_piper4 = sub_angle > 45;
        if(greater_than_piper4) sub_angle = 90 - sub_angle;

        double tan = Math.Tan(sub_angle * (Math.PI / 180));
        res_x = radius / Math.Pow((1 + Math.Pow(tan, k)), 1/k);
        res_y = res_x * tan;

        // [pi/4, pi/2)のときはswap
        if(greater_than_piper4){
            double _tmp = res_x;
            res_x = res_y;
            res_y = _tmp;
        }

        // half_pi_numの回数だけpi/2回転
        for (int i = 0; i < half_pi_num; i++)
        {
            double _tmp = res_x;
            res_x = -res_y;
            res_y = _tmp;
        }
        return (res_x, -res_y);
    }
}
