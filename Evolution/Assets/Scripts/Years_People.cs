using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Years_People : MonoBehaviour
{
    public int YearsPlus=0, PeoplePlus=0,MonthPlus=0,DayPlus=0;
    //[HideInInspector] public int Level = 1, RndMinYear = 50, RndMaxYear = 0, RndMinMonth=150,RndMaxMonth=0, Selection;
    //[HideInInspector] public int RndMaxDay = 0,RndMinDay=250,RndMinPeople=2,RndMaxPeople=0;
    public TextMeshPro Text;

    private void Awake()
    {
        /*RndMinYear = RndMinYear - (50 * Level); // Trigger yýl ekleme vs otomatikleþtirme
        RndMaxYear = RndMaxYear + (50 * Level);

        RndMinMonth = RndMinMonth - (150 * Level);
        RndMaxMonth = RndMaxMonth + (150 * Level);

        RndMinDay = RndMinDay - (250 * Level);
        RndMaxDay = RndMaxDay + (250 * Level);

        RndMinPeople = RndMinPeople - (2 * Level);
        RndMaxPeople = RndMaxPeople + (2 * Level);

        Selection = Random.Range(1, 4);
        if (Selection == 1)
        {
            YearsPlus = Random.Range(RndMinYear,RndMaxYear);
        }
        if (Selection == 2)
        {
            MonthPlus = Random.Range(RndMinMonth, RndMaxMonth);
        }
        if (Selection == 3)
        {
            DayPlus = Random.Range(RndMinDay, RndMaxDay);
        }
        if (Selection == 4)
        {
            PeoplePlus = Random.Range(RndMinPeople, RndMaxPeople);
        }*/

    }
    void Start()
    {
        if(YearsPlus != 0)
        {
            gameObject.tag = "TriggerYear";

            if(YearsPlus > 0)
                Text.text = "+" + YearsPlus.ToString() + " Yýl";
            else if(YearsPlus < 0)
                Text.text = YearsPlus.ToString() + " Yýl";

        }
        if(PeoplePlus != 0)
        {
            gameObject.tag = "TriggerPeople";

            if(PeoplePlus>0)
                Text.text = "+" + PeoplePlus.ToString() + " Kiþi";
            else if(PeoplePlus < 0)
                Text.text =  PeoplePlus.ToString() + " Kiþi";

        }
        if(MonthPlus != 0)
        {
            gameObject.tag = "TriggerYear";
            YearsPlus = MonthPlus / 12;

            if(MonthPlus > 0)
                Text.text = "+" + MonthPlus.ToString() + " Ay";
            else if(MonthPlus < 0)
                Text.text =  MonthPlus.ToString() + " Ay";


        }
        if (DayPlus != 0)
        {
            gameObject.tag = "TriggerYear";
            YearsPlus = DayPlus / 365;
            if(DayPlus > 0)
                Text.text = "+" + DayPlus.ToString() + " Gün";
            else if (DayPlus < 0)
                Text.text =  DayPlus.ToString() + " Gün";

        }

    }

    void Update()
    {
        
    }
}
