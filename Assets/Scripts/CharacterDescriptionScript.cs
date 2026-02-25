using TMPro;
using UnityEngine;

public class CharacterDescriptionScript : MonoBehaviour
{
    private string text;
    public ScrollScript scrollScript;
    public TMP_Text textField;

    public void CharacterDescriptionChange()
    {
        if(scrollScript.characterIndex == 0)
        {
            text = "Character description: white male jewish";
        }else if(scrollScript.characterIndex == 1)
        {

        }
        else
        {

        }
    }
}
