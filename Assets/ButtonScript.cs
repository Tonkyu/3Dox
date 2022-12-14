using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonScript : MonoBehaviour
{
	public TextMeshProUGUI label;
	public int row_id, col_id;
	public BlockScript[] tiedBlocks = new BlockScript[3];

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
		createBall(0);
    }

	public void onPointerEnter()
	{
		changeColorTo(true);
	}

	public void onPointerExit()
	{
		changeColorTo(false);
	}

	void changeColorTo(bool flag)	// flag = false -> default, true->selected
	{
		foreach (BlockScript block in tiedBlocks)
		{
			if(block.isSelected() != flag) block.changeColor();
		}
	}

	void createBall(int player)
	{
		int change_block_num = getChangeBlockNum();
		if(change_block_num < 0)
		{
			Debug.Log("Can't place Balls anymore!");
			return;
		}
		tiedBlocks[change_block_num].setBall();
	}

	int getChangeBlockNum(){
		for (int i = 0; i < tiedBlocks.Length; i++)
		{
			if(!tiedBlocks[i].isFilled())
			{
				return i;
			}
		}
		return -1;
	}
}
