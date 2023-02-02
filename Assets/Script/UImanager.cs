using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
  [SerializeField] private Text NoteText1, NoteText2, NoteText3, NoteText4, NoteText5, NoteText6, 
   NoteText7, NoteText8, NoteText9, NoteText10, NoteText11, NoteText12, NoteText13, NoteText14, 
   NoteText15, NoteText16, NoteText17, NoteText18, NoteText19, NoteText20, InputText1, InputText2, 
   InputText3, InputText4, InputText5, InputText6, InputText7, InputText8, InputText9, InputText10, 
   InputText11, InputText12, InputText13, InputText14, InputText15, InputText16, InputText17,
   InputText18, InputText19, InputText20;
   [SerializeField] private InputField InputField1, InputField2,InputField3, InputField4, InputField5,
   InputField6, InputField7, InputField8, InputField9, InputField10, InputField11, InputField12,
   InputField13, InputField14, InputField15, InputField16, InputField17, InputField18, InputField19, InputField20;
   [SerializeField] private string Note1, Note2, Note3, Note4, Note5, Note6, 
   Note7, Note8, Note9, Note10, Note11, Note12, Note13, Note14, Note15, Note16, Note17, Note18, Note19, Note20;
    
   public void SaveInputText1()
    {
        Note1 = InputText1.text;
        NoteText1.text = Note1;
    }
     public void clearInputText1()
    {
        InputField1.text = "";
        NoteText1.text = "Заметка 1";
    }
 
    public void SaveInputText2()
    {
        Note2 = InputText2.text;
        NoteText2.text = Note2;
    }
     public void clearInputText2()
    {
        InputField2.text = "";
        NoteText2.text = "Заметка 2";
    }
    
    public void SaveInputText3()
    {
        Note3 = InputText3.text;
        NoteText3.text = Note3;
    }
     public void clearInputText3()
    {
        InputField3.text = "";
        NoteText3.text = "Заметка 3";
    }
    
    public void SaveInputText4()
    {
        Note4 = InputText4.text;
        NoteText4.text = Note4;
    }
     public void clearInputText4()
    {
        InputField4.text = "";
        NoteText4.text = "Заметка 4";
    }
    
    public void SaveInputText5()
    {
        Note5 = InputText5.text;
        NoteText5.text = Note5;
    }
    public void clearInputText5()
    {
        InputField5.text = "";
        NoteText5.text = "Заметка 5";
    }
    
    public void SaveInputText6()
    {
        Note6 = InputText6.text;
        NoteText6.text = Note6;
    }
     public void clearInputText6()
    {
        InputField6.text = "";
        NoteText6.text = "Заметка 6";
    }
    
    public void SaveInputText7()
    {
        Note7 = InputText7.text;
        NoteText7.text = Note7;
    }
     public void clearInputText7()
    {
        InputField7.text = "";
        NoteText7.text = "Заметка 7";
    }
    
    public void SaveInputText8()
    {
        Note8 = InputText8.text;
        NoteText8.text = Note8;
    }
     public void clearInputText8()
    {
        InputField8.text = "";
        NoteText8.text = "Заметка 8";
    }
    
    public void SaveInputText9()
    {
        Note9 = InputText9.text;
        NoteText9.text = Note9;
    }
     public void clearInputText9()
    {
        InputField9.text = "";
        NoteText9.text = "Заметка 9";
    }
    
    public void SaveInputText10()
    {
        Note10 = InputText10.text;
        NoteText10.text = Note10;
    }
     public void clearInputText10()
    {
        InputField10.text = "";
        NoteText10.text = "Заметка 10";
    }
    
    public void SaveInputText11()
    {
        Note11 = InputText11.text;
        NoteText11.text = Note11;
    }
     public void clearInputText11()
    {
        InputField11.text = "";
        NoteText11.text = "Заметка 11";
    }
    
    public void SaveInputText12()
    {
        Note12 = InputText12.text;
        NoteText12.text = Note12;
    }
     public void clearInputText12()
    {
        InputField12.text = "";
        NoteText12.text = "Заметка 12";
    }
    
    public void SaveInputText13()
    {
        Note13 = InputText1.text;
        NoteText13.text = Note13;
    }
     public void clearInputText13()
    {
        InputField13.text = "";
        NoteText13.text = "Заметка 13";
    }
    
    public void SaveInputText14()
    {
        Note14 = InputText14.text;
        NoteText14.text = Note14;
    }
     public void clearInputText14()
    {
        InputField14.text = "";
        NoteText14.text = "Заметка 14";
    }
    
    public void SaveInputText15()
    {
        Note15 = InputText15.text;
        NoteText15.text = Note15;
    }
     public void clearInputText15()
    {
        InputField15.text = "";
        NoteText15.text = "Заметка 15";
    }
    
    public void SaveInputText16()
    {
        Note16 = InputText16.text;
        NoteText16.text = Note16;
    }
     public void clearInputText16()
    {
        InputField16.text = "";
        NoteText16.text = "Заметка 16";
    }
    
    public void SaveInputText17()
    {
        Note17 = InputText17.text;
        NoteText17.text = Note17;
    }
     public void clearInputText17()
    {
        InputField17.text = "";
        NoteText17.text = "Заметка 17";
    }
    
    public void SaveInputText18()
    {
        Note18 = InputText18.text;
        NoteText18.text = Note18;
    }
     public void clearInputText18()
    {
        InputField18.text = "";
        NoteText18.text = "Заметка 18";
    }
    
    public void SaveInputText19()
    {
        Note19 = InputText19.text;
        NoteText19.text = Note19;
    }
     public void clearInputText19()
    {
        InputField19.text = "";
        NoteText19.text = "Заметка 19";
    }
    
    public void SaveInputText20()
    {
        Note20 = InputText20.text;
        NoteText20.text = Note20;
    }
     public void clearInputText20()
    {
        InputField20.text = "";
        NoteText20.text = "Заметка 20";
    }
  
}