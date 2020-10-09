using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderItemManager : MonoBehaviour {

    public Text PortionText;
    [HideInInspector]
    public int Cost = 20;
    [HideInInspector]
    public string OName;

    private Text CostText;
    private LanguageManager Language;
    private int CurrentSumm = 0;
    private int PortionCount = 0;
    private OrdersListResult OList;
    public int TimeToLeft = 0;

    void Start()
    {
        CostText = GameObject.FindGameObjectWithTag("SummText").GetComponent<Text>();
        Language = FindObjectOfType<LanguageManager>();
        CurrentSumm = FindObjectOfType<GeneralSummHandler>().GeneralSum;
        OList = FindObjectOfType<OrdersListResult>();
    }

    public void Plus()
    {
        CurrentSumm = FindObjectOfType<GeneralSummHandler>().GeneralSum;
        PortionCount += 1;
        PortionText.text = PortionCount.ToString();
        CurrentSumm += Cost;
        FindObjectOfType<GeneralSummHandler>().GeneralSum += Cost;
        OList.OrdersList.Add(OName);
        OList.OrdersCostList.Add(Cost);
        OList.TimeToLeftList.Add((TimeToLeft * 60));
        switch (Language.SelectedLanguage)
        {
            case LanguageManager.Language.Tajik:
                CostText.text = "Сомони: " + CurrentSumm.ToString();
                break;
            case LanguageManager.Language.Russian:
                CostText.text = string.Format("Общая Сумма: {0} Сомони", CurrentSumm.ToString());
                break;
            case LanguageManager.Language.English:
                CostText.text = string.Format("General Sum: {0} Somoni", CurrentSumm.ToString());
                break;
        }
    }

    public void Minus()
    {
        CurrentSumm = FindObjectOfType<GeneralSummHandler>().GeneralSum;
        PortionCount -= 1;
        PortionText.text = PortionCount.ToString();
        CurrentSumm -= Cost;
        FindObjectOfType<GeneralSummHandler>().GeneralSum -= Cost;
        OList.OrdersList.RemoveAt(PortionCount);
        OList.TimeToLeftList.RemoveAt(PortionCount);
        OList.OrdersCostList.RemoveAt(PortionCount);
        switch (Language.SelectedLanguage)
        {
            case LanguageManager.Language.Tajik:
                CostText.text = "Сомони: " + CurrentSumm.ToString();
                break;
            case LanguageManager.Language.Russian:
                CostText.text = string.Format("Общая Сумма: {0} Сомони", CurrentSumm.ToString());
                break;
            case LanguageManager.Language.English:
                CostText.text = string.Format("General Sum: {0} Somoni", CurrentSumm.ToString());
                break;
        }
    }
}
