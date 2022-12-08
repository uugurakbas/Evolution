using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Years_People : MonoBehaviour
{
    public int YearsPlus=0, PeoplePlus=0,MonthPlus=0,DayPlus=0;
    public TextMeshPro Text;
    public bool multiplied = false;

    private void Awake()
    {


    }
    void Start()
    {
        if(YearsPlus != 0)
        {
            gameObject.tag = "TriggerYear";

            if (multiplied)
            {
                Text.text = "X" + YearsPlus.ToString() + " Y�l";
            }
            else
            {
                if (YearsPlus > 0)
                    Text.text = "+" + YearsPlus.ToString() + " Y�l";
                else if (YearsPlus < 0)
                    Text.text = YearsPlus.ToString() + " Y�l";
            }

        }
        if(PeoplePlus != 0)
        {
            gameObject.tag = "TriggerPeople";


            if (multiplied)
            {
                Text.text = "X" + PeoplePlus.ToString() + " Ki�i";
            }
            else
            {

                if (PeoplePlus > 0)
                    Text.text = "+" + PeoplePlus.ToString() + " Ki�i";
                else if (PeoplePlus < 0)
                    Text.text = PeoplePlus.ToString() + " Ki�i";
            }

        }
        if(MonthPlus != 0)
        {
            gameObject.tag = "TriggerYear";
            YearsPlus = MonthPlus / 12;

            if (MonthPlus > 0)
                Text.text = "+" + MonthPlus.ToString() + " Ay";
            else if (MonthPlus < 0)
                Text.text = MonthPlus.ToString() + " Ay";



        }
        if (DayPlus != 0)
        {
            gameObject.tag = "TriggerYear";
            YearsPlus = DayPlus / 365;


            if (DayPlus > 0)
                Text.text = "+" + DayPlus.ToString() + " G�n";
            else if (DayPlus < 0)
                Text.text =  DayPlus.ToString() + " G�n";

        }

    }

    void Update()
    {
        
    }
}
