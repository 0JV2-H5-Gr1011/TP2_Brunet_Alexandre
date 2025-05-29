using UnityEngine;
using UnityEngine.UI;

public class ChampTexteSauvegarde : MonoBehaviour
{
    public InputField champTexte;
    public string cleSauvegarde = "TexteSauvegarde";

    void Start()
    {
        if (PlayerPrefs.HasKey(cleSauvegarde))
        {
            champTexte.text = PlayerPrefs.GetString(cleSauvegarde);
        }

        champTexte.onEndEdit.AddListener(SauvegarderTexte);
    }

    void SauvegarderTexte(string texte)
    {
        PlayerPrefs.SetString(cleSauvegarde, texte);
        PlayerPrefs.Save();
    }
}
