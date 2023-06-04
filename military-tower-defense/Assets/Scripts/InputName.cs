using TMPro;
using UnityEngine;

public class InputName : MonoBehaviour
{
    public TMP_InputField inputField;

    void Start()
    {
        inputField.onEndEdit.AddListener(delegate { UpdateText(); });

        if (PlayerPrefs.HasKey("name"))
        {
            inputField.text = PlayerPrefs.GetString("name");
        }
    }

    void UpdateText()
    {
        PlayerPrefs.SetString("name", inputField.text);
    }
}
