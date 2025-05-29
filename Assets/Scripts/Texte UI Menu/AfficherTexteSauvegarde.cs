using UnityEngine;
using TMPro;

public class AfficherTexteSauvegarde : MonoBehaviour
{
    public TextMeshProUGUI cibleTexte;

    void Start()
    {
        cibleTexte.text = TexteSauvegarde.texte;
    }
}
