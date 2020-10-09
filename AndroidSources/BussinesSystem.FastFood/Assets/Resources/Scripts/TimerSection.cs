using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSection : MonoBehaviour {

	public Text TimerCaption;
	public Text ButtonCaption;

	public LanguageManager Language;

	public void Begin()
	{
		switch (Language.SelectedLanguage) {
		case LanguageManager.Language.Tajik:
			TimerCaption.text = "Вахти мондагий";
			ButtonCaption.text = "OK";
			break;
		case LanguageManager.Language.Russian:
			TimerCaption.text = "Оставшееся время";
			ButtonCaption.text = "Далее";
			break;
		case LanguageManager.Language.English:
			TimerCaption.text = "Remaining Time";
			ButtonCaption.text = "Next";
			break;
		}
	}
}