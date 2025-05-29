using UnityEngine;
using TMPro;

public class SauvegardeTexte : MonoBehaviour
{
    public TMP_InputField champTexte;

    void Start()
    {
        if (PlayerPrefs.HasKey("TexteSauvegarde"))
        {
            champTexte.text = PlayerPrefs.GetString("TexteSauvegarde");
        }
    }

    void OnDisable()
    {
        PlayerPrefs.SetString("TexteSauvegarde", champTexte.text);
        PlayerPrefs.Save();
    }
}
