using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    private string text;
    private int age;
    public TMP_Text textField;
    public TMP_InputField inputField;
    public TMP_InputField inputYear;

    void Start()
    {
        inputYear.contentType = TMP_InputField.ContentType.IntegerNumber;
    }
    public void setAge()
    {
        text = inputYear.text;
        age = (DateTime.Now.Year) - int.Parse(inputYear.text);
    }
    public void setName()
    {
        text = inputField.GetComponent<TMP_InputField>().text;
        textField.GetComponent<TMP_Text>().text = text + " ir " + age + " gadus vecs!";
    }
}
