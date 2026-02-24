using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{
    public Image characterImage;
    public Sprite[] characterSprites;
    public Slider heightSlider;
    public Slider widthSlider;
    public void ChangeCharacterImage(int index)
    {
        characterImage.GetComponent<Image>().sprite = characterSprites[index];
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
