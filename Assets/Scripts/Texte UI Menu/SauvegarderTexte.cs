using UnityEngine;
using TMPro;

public class SauvegarderTexte : MonoBehaviour
{
    public TMP_InputField champTexte;

    public void Sauvegarder()
    {
        TexteSauvegarde.texte = champTexte.text;
    }
}
