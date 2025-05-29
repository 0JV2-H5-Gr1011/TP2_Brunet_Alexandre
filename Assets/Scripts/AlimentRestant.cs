using UnityEngine;
using TMPro;

public class AlimentRestant : MonoBehaviour
{
    public string tagAliment = "Compost";
    public TextMeshProUGUI texte;
    public RamassageCompost joueur;
    public AudioSource audioSource;
    public AudioClip sonTermine;
    public TextMeshProUGUI texteFin;

    private bool sonJoue = false;

    void Start()
    {
        texte.fontSize = 46;
        texte.fontStyle = FontStyles.Bold;
        texte.color = new Color(0.4f, 0.7f, 1f);
        texte.enableWordWrapping = false;
    }

    void Update()
    {
        int restant = GameObject.FindGameObjectsWithTag(tagAliment).Length;
        texte.text = "Aliments restants : " + restant;

        if (restant == 0 && joueur.objetTenu == null && !sonJoue)
        {
            if (audioSource && sonTermine) audioSource.PlayOneShot(sonTermine);
            if (texteFin != null)
            {
                texteFin.text = "Dirigez-vous vers la <color=yellow>porte de sortie</color>";
            }
            sonJoue = true;
        }
    }
}
