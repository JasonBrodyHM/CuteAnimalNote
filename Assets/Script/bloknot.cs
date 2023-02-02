using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bloknot : MonoBehaviour {

	public InputField inp;


	void Start()
	{
		string txt = "";
		txt = PlayerPrefs.GetString("TestB","");
		//Debug.Log(txt);
		txt = txt.Replace("■","\n");
		//Debug.Log(txt);
		inp.text = txt;
	}

	public void End(GameObject obj)
	{
		string text = "";
		string tosave = "";
		text = obj.GetComponent<InputField>().text;
		tosave = text.Replace("\n", "■");
		PlayerPrefs.SetString("TestB", tosave);
		PlayerPrefs.Save();
	}
}
