using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class OrdersList : MonoBehaviour {

    public GameObject ChildOrderItemTemplate;
    public GameObject ParentContent;
    public Text SummText, NextButtonText;
    public LanguageManager Language;

    private string JSONData;
    private string JSONString;
    private Orders m_Orders;

    public Transform Content;
    public OrdersListResult OListResults;

    public void Begin()
    {
        DirectoryInfo Dinfo = new DirectoryInfo(Application.streamingAssetsPath + "/Kebabs");
        FileInfo[] info = Dinfo.GetFiles("*.json");
        foreach (FileInfo finf in info)
        {
            GameObject SpawnedTemplate = Instantiate(ChildOrderItemTemplate);
            SpawnedTemplate.transform.parent = ParentContent.transform;
            JSONData = Application.streamingAssetsPath + "/Kebabs/" + finf.Name;
            JSONString = File.ReadAllText(JSONData);
            m_Orders = JsonUtility.FromJson<Orders>(JSONString);
            SpawnedTemplate.GetComponent<OrderItemManager>().Cost = m_Orders.Cost;
			SpawnedTemplate.GetComponent<OrderItemManager> ().TimeToLeft = m_Orders.Time;
            switch (Language.SelectedLanguage)
            {
			case LanguageManager.Language.Tajik:
				    SpawnedTemplate.GetComponentInChildren<Text> ().text = m_Orders.NameTJK + "\nТаркиб:" + m_Orders.ContentTJK + "\nВахт:" + m_Orders.Time + "\nСомони" + m_Orders.Cost;
				    SpawnedTemplate.GetComponent<OrderItemManager> ().OName = m_Orders.NameTJK;
                    SummText.text = "Сомони: 0";
                    NextButtonText.text = "ОК";
                    break;
               case LanguageManager.Language.Russian:
                    SpawnedTemplate.GetComponentInChildren<Text>().text = m_Orders.NameRUS + "\nСостав:" + m_Orders.ContentRUS + "\nВремя:" + m_Orders.Time + "\nСомони:" + m_Orders.Cost;
                    SpawnedTemplate.GetComponent<OrderItemManager>().OName = m_Orders.NameRUS;
                    SummText.text = "Общая Сумма: 0 Сомони";
                    NextButtonText.text = "Далее";
                    break;
               case LanguageManager.Language.English:
                    SpawnedTemplate.GetComponentInChildren<Text>().text = m_Orders.NameENG + "\nContent:" + m_Orders.ContentENG + "\nTime:" + m_Orders.Time + "\nCost:" + m_Orders.Cost;
                    SpawnedTemplate.GetComponent<OrderItemManager>().OName = m_Orders.NameENG;
                    SummText.text = "General Sum: 0 Somoni";
                    NextButtonText.text = "Next";
                    break;
            }

            //float LastHeight = Content.transform.localScale.y;
            //Content.transform.localScale = new Vector3(1, LastHeight + 30, 1);
        }
    }
}

[System.Serializable]
public class Orders
{
    public string Image;
    public string NameTJK;
    public string NameRUS;
    public string NameENG;
    public string ContentTJK;
    public string ContentRUS;
    public string ContentENG;
    public int Time;
    public int Cost;
}
