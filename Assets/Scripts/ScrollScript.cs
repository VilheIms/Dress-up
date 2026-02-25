using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{
    public GameObject hoodie;
    public GameObject tactical;
    public GameObject tanktop;
    public GameObject TTsKO;
    public Image characterImage;
    public Sprite[] characterSprites;
    public Slider heightSlider;
    public Slider widthSlider;
    public int characterIndex;
    public void ChangeCharacterImage(int index)
    {
        characterIndex = index;
        characterImage.GetComponent<Image>().sprite = characterSprites[index];
    }
    public void ToggleShirts(bool value)
    {
        hoodie.SetActive(value);
        tactical.SetActive(value);
        tanktop.SetActive(value);
        TTsKO.SetActive(value);
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
