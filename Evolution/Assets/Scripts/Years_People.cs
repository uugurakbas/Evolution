using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Years_People : MonoBehaviour
{
    public int YearsPlus=0, PeoplePlus=0;
    public TextMeshPro Text;
    void Start()
    {
        if(YearsPlus != 0)
        {
            Text.text = "+" + YearsPlus.ToString() + " Y�l";
        }
        if(PeoplePlus != 0)
        {
            Text.text = "+" + PeoplePlus.ToString() + " Ki�i";
        }
        
    }

    void Update()
    {
        
    }
}
