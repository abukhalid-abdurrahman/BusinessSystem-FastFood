using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class FoodOrderType : MonoBehaviour {

	private string JSONData;
	private string JSONString;
    private FoodOrder Types;
    private string[] FoodOrdersTypes;
    private string TitleString;

    public Text[] FoodOrdersButton;
    public Text TitleText;
    public LanguageManager Language; 

    void Start()
	{
        JSONData = Application.streamingAssetsPath + "/foodTypesList.json";
        JSONString = File.ReadAllText(JSONData);
        Types = JsonUtility.FromJson<FoodOrder>(JSONString);
    }

    public void Begin()
    {
        switch (Language.SelectedLanguage)
        {
            case LanguageManager.Language.Tajik:
                FoodOrdersTypes = Types.TypesTJK;
                TitleString = Types.TitleTJK;
                break;
            case LanguageManager.Language.Russian:
                FoodOrdersTypes = Types.TypesRUS;
                TitleString = Types.TitleRUS;
                break;
            case LanguageManager.Language.English:
                FoodOrdersTypes = Types.TypesENG;
                TitleString = Types.TitleENG;
                break;
        }

        TitleText.text = TitleString;

        for (int i = 0; i < FoodOrdersButton.Length; i++)
            FoodOrdersButton[i].text = FoodOrdersTypes[i];
    }
}

[System.Serializable]
public class FoodOrder
{
    public string TitleTJK;
    public string TitleRUS;
    public string TitleENG;
    public string[] TypesTJK;
    public string[] TypesRUS;
    public string[] TypesENG;
}
