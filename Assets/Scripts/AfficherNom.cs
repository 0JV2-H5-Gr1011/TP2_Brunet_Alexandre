using UnityEngine;
using TMPro;

public class AfficherNom : MonoBehaviour
{
    public TMP_Text texteNom;

    void Start()
    {
        if (PlayerPrefs.HasKey("NomChoisi"))
        {
            texteNom.text = PlayerPrefs.GetString("NomChoisi");
        }
    }
}
