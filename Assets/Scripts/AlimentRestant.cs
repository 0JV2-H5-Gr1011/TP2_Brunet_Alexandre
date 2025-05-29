using UnityEngine;
using TMPro;

public class AlimentRestant : MonoBehaviour
{
    public string tagAliment = "Compost";
    public TextMeshProUGUI texte;

    void Start()
    {
        texte.fontSize = 46;
        texte.fontStyle = FontStyles.Bold;
        texte.color = new Color(0.1f, 0.3f, 0.6f);
        texte.enableWordWrapping = false;
    }

    void Update()
    {
        int restant = GameObject.FindGameObjectsWithTag(tagAliment).Length;
        texte.text = "Aliments restants : " + restant;
    }
}
