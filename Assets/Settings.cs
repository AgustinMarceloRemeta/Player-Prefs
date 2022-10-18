using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;

    private void Start() => GetValues();
    

    private void GetValues()
    {
      nameInput.text = PlayerPrefs.HasKey("inputName") ?  PlayerPrefs.GetString("inputName") : "";
      volumeSlider.value = PlayerPrefs.HasKey("volume")? PlayerPrefs.GetFloat("volume") : 0 ;
      resolution.value = PlayerPrefs.HasKey("resolution") ? PlayerPrefs.GetInt("resolution") : 0;
     
    }

    public void SetVolumen() => PlayerPrefs.SetFloat("volume", volumeSlider.value);


    public void SetName() => PlayerPrefs.SetString("inputName", nameInput.text);  


    public void SetResolution() => PlayerPrefs.SetInt("resolution", resolution.value);


    public void ResetDefault()
    {
        PlayerPrefs.DeleteAll();
        GetValues();
    }
}
