using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Cutscene : MonoBehaviour
{
    public Canvas[] dialogues;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {      
        for(int j=0; j<=8;j++)
        {
            dialogues[j].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            dialogues[0].enabled = true;
        }
    }
    public void Dialogue1()
    {
        for (int j = 0; j <= 8 && j != 1; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[1].enabled = true;
    }
    public void Dialogue2()
    {
        for (int j = 0; j <= 8 && j != 2; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[2].enabled = true;
    }
    public void Dialogue3()
    {
        for (int j = 0; j <= 8 && j != 3; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[3].enabled = true;
    }
    public void Dialogue4()
    {
        for (int j = 0; j <= 8 && j != 4; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[4].enabled = true;
    }
    public void Dialogue5()
    {
        for (int j = 0; j <= 8 && j != 5; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[5].enabled = true;
    }
    public void Dialogue6()
    {
        for (int j = 0; j <= 8 && j != 6; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[6].enabled = true;
    }
    public void End1()
    {
        for (int j = 0; j <= 8 && j != 7; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[7].enabled = true;
    }
    public void End2()
    {
        for (int j = 0; j <= 8 && j != 8; j++)
        {
            dialogues[j].enabled = false;
        }
        dialogues[8].enabled = true;
    }
}
