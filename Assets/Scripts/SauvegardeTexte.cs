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

    public **void** SauvegarderTexte() // Change to PUBLIC
    {
        PlayerPrefs.SetString("TexteSauvegarde", champTexte.text);
        PlayerPrefs.Save();
    }
}
