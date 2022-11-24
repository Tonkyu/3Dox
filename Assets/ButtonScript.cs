using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonScript : MonoBehaviour
{
	public TextMeshProUGUI label;
	private int row_id, col_id;
	private string num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        Debug.Log(label.GetParsedText());
		// label.text = text.text + text.text;
    }

	void setNums(int _row_id, int _col_id)
	{
		row_id = _row_id;
		col_id = _col_id;
		num = (row_id * 3 + col_id + 1).ToString();
		label.SetText(num);
	}
}
