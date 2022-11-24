using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonScript : MonoBehaviour
{
	public TextMeshProUGUI label;

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

}
