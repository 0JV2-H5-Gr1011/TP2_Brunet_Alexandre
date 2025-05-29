using UnityEngine;
using TMPro;

public class AlimentRestant : MonoBehaviour
{
    public TextMeshProUGUI texte;

    void Update()
    {
        int nombre = GameObject.FindGameObjectsWithTag("Compost").Length;
        texte.text = "Aliments restants : " + nombre;
    }
}
