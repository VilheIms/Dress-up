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

    public void ChangeWidth()
    {
        float widthValue = widthSlider.GetComponent<Slider>().value;
        characterImage.transform.localScale = new Vector2(1.1f * widthValue, 1);
    }

    public void ChangeHeight()
    {
        float sizeValue = heightSlider.GetComponent<Slider>().value;
        characterImage.transform.localScale = new Vector2(1, 1.1f * sizeValue);
    }

}
