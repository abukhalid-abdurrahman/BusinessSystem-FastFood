using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class OrdersListResult : MonoBehaviour {

    public LanguageManager Language;

    [HideInInspector]
    public List<string> OrdersList;
    [HideInInspector]
    public List<int> OrdersCostList;
    [HideInInspector]
    public List<int> TimeToLeftList;
    [HideInInspector]
    public int TableIndex = 0;
    [HideInInspector]
    public int GeneralSumm = 0;
    public GeneralSummHandler GSH;
    public Text TableNumber;
    public Text GeneralSum;
    public Transform Content;
    public GameObject ChildObject;
    public Timer m_Timer;
	public SendOrdersToServer SendData;

    private string[] OrdersNameArray;
    private int[] OrdersCostArray;
    private int[] TimeToLeftArray;
    public void Begin()
    {
        TableIndex = System.Convert.ToInt32(IOUtility.ReadFromFileValue(Application.persistentDataPath + "\\" + "settings.set", 0));
        GeneralSumm = GSH.GeneralSum;

        switch (Language.SelectedLanguage)
        {
            case LanguageManager.Language.Tajik:
                TableNumber.text = "Стол №" + TableIndex;
                GeneralSum.text = "Сомони: " + GeneralSumm;
                break;
            case LanguageManager.Language.Russian:
                TableNumber.text = "Стол №" + TableIndex;
                GeneralSum.text = "Общая Сумма(Сомони): " + GeneralSumm;
                break;
            case LanguageManager.Language.English:
                TableNumber.text = "Table №" + TableIndex;
                GeneralSum.text = "General Summ: " + GeneralSumm;
                break;
        }

        OrdersNameArray = OrdersList.ToArray();
        OrdersCostArray = OrdersCostList.ToArray();

        for (int i = 0; i < OrdersNameArray.Length; i++)
        {
           GameObject TemplateChildObject = GameObject.Instantiate(ChildObject);
           TemplateChildObject.transform.parent = Content;
           TemplateChildObject.GetComponent<Text>().text = OrdersNameArray[i] + "      " + OrdersCostArray[i];
        }
    }

    public void SendDataTimer()
    {
        TimeToLeftArray = TimeToLeftList.ToArray();
        for (int i = 0; i < TimeToLeftArray.Length; i++)
        {
            m_Timer.LeftTime += TimeToLeftArray[i];
        }
    }

	public void SendDataToServerManager()
	{
		SendData.OrdersName = OrdersNameArray;
		SendData.OrdersPrice = OrdersCostArray;
	}
}
