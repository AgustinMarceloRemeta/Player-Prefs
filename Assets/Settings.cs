using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;

    private void Start()
    {
        GetValues();
    }

    private void GetValues()
    {
        if (PlayerPrefs.HasKey("inputName")) nameInput.text = PlayerPrefs.GetString("inputName");
        else PlayerPrefs.SetString("inputName", nameInput.text);

        if (PlayerPrefs.HasKey("volume")) volumeSlider.value = PlayerPrefs.GetFloat("volume");
        else PlayerPrefs.SetFloat("volume", volumeSlider.value);

        if (PlayerPrefs.HasKey("resolution")) resolution.value = PlayerPrefs.GetInt("resolution");
        else PlayerPrefs.SetInt("resolution", resolution.value);
    }

    public void SetVolumen()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }

    public void SetName()
    {
        PlayerPrefs.SetString("inputName", nameInput.text);  
    }

    public void SetResolution()
    {
        PlayerPrefs.SetInt("resolution", resolution.value);
    }

    public void ResetDefault()
    {
        PlayerPrefs.DeleteAll();
    }
}
