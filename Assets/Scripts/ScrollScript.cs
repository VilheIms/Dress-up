using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{
    public GameObject hoodie;
    public GameObject tactical;
    public GameObject tanktop;
    public GameObject TTsKO;
    public GameObject CamoPants;
    public GameObject PantsOtherCamo;
    public GameObject Jeans;
    public GameObject Rags;
    public GameObject Tinfoil;
    public GameObject Headband;
    public GameObject Headphones;
    public GameObject Beans;
    public GameObject Knife;
    public GameObject Axe;
    public Image characterImage;
    public Sprite[] characterSprites;
    public Slider heightSlider;
    public Slider widthSlider;
    public int characterIndex;
    public TMP_Text textField;
    public void ChangeCharacterImage(int index)
    {
        characterIndex = index;
        characterImage.GetComponent<Image>().sprite = characterSprites[index];
        if(index == 0)
        {
            textField.GetComponent<TMP_Text>().text = "Character: \n A standard citizen of robloxia, ready to get dressed for work.";
        }else if(index == 1)
        {
            textField.GetComponent<TMP_Text>().text = "Character: \n An adventurous man, getting ready for the next adventure.";
        }else if(index == 2)
        {
            textField.GetComponent<TMP_Text>().text = "Character: \n A rare noob, who just wants to pwn his own kind.";
        }
    }
    public void ToggleShirts(bool value)
    {
        hoodie.SetActive(value);
        tactical.SetActive(value);
        tanktop.SetActive(value);
        TTsKO.SetActive(value);
    }
    public void TogglePants(bool value)
    {
        CamoPants.SetActive(value);
        PantsOtherCamo.SetActive(value);
        Jeans.SetActive(value);
        Rags.SetActive(value);
    }
    public void ToggleHats(bool value)
    {
        Tinfoil.SetActive(value);
        Headband.SetActive(value);
        Headphones.SetActive(value);
    }
    public void ToggleOther(bool value)
    {
        Beans.SetActive(value);
        Knife.SetActive(value);
        Axe.SetActive(value);
    }
    public void Sliders()
    {
        widthSlider.onValueChanged.AddListener(delegate { Change(); });

        heightSlider.onValueChanged.AddListener(delegate { Change(); });
    }
    public void Change()
    {
        characterImage.transform.localScale = new Vector3(widthSlider.value, heightSlider.value, 1f);
    }
}
