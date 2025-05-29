using UnityEngine;
using TMPro;

public class NourritureRestante : MonoBehaviour
{
    public string tagAliment = "Nourriture";
    public TextMeshProUGUI texte;
    public RamassageRouge joueur;
    public AudioSource audioSource;
    public AudioClip sonTermine;

    private bool sonJoue = false;

    void Start()
    {
        texte.fontSize = 46;
        texte.fontStyle = FontStyles.Bold;
        texte.color = new Color(1f, 0.4f, 0.4f);
        texte.enableWordWrapping = false;
    }

    void Update()
    {
        int restant = GameObject.FindGameObjectsWithTag(tagAliment).Length;
        texte.text = "Nourritures restantes : " + restant;

        if (restant == 0 && joueur.objetTenu == null && !sonJoue)
        {
            JouerSon();
            sonJoue = true;
        }
    }

    public void ChoisirSon(AudioClip nouveauSon)
    {
        sonTermine = nouveauSon;
    }

    void JouerSon()
    {
        if (audioSource && sonTermine)
        {
            audioSource.PlayOneShot(sonTermine);
        }
    }
}
