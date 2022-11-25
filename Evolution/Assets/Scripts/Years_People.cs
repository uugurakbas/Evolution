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
            Text.text = "+" + YearsPlus.ToString() + " Yýl";
        }
        if(PeoplePlus != 0)
        {
            Text.text = "+" + PeoplePlus.ToString() + " Kiþi";
        }
        
    }

    void Update()
    {
        
    }
}
