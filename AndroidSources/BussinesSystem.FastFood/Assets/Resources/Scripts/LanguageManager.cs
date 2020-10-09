using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour {

    [HideInInspector]
    public enum Language
    {
        Tajik,
        Russian,
        English
    };

    public Language SelectedLanguage;

    public void RussianLanguage(bool Value)
    {
        if (Value)
            SelectedLanguage = Language.Russian;
    }

    public void TajikLanguage(bool Value)
    {
        if (Value)
            SelectedLanguage = Language.Tajik;
    }

    public void EnglishLanguage(bool Value)
    {
        if (Value)
            SelectedLanguage = Language.English;
    }
}
