using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    public Text InputedTableIndex;
    public InputField InputedFieldTableIndex;
    public Text PasswordInputField;
    public string Password = "2002-Faridun-2002";     
    private string FileName;

    void Start()
    {
        FileName = Application.persistentDataPath + "\\" + "settings.set";
        IOUtility.isFileExists(FileName);
    }

    public void isPassword(string iText)
    {
        if (iText != Password)
            InputedFieldTableIndex.interactable = false;
        else if(iText == Password)
            InputedFieldTableIndex.interactable = true;
    }

    public void Save()
    {
        IOUtility.WriteToFileValue(FileName, InputedTableIndex.text, false);
    }

    public void Load()
    {
        InputedTableIndex.text = IOUtility.ReadFromFileValue(FileName, 0);
    }
}
