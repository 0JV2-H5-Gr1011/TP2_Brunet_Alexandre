using UnityEngine;
using TMPro;

public class VerreRestant : MonoBehaviour
{
    public string tagAliment = "Verre";
    public TextMeshProUGUI texte;
    public RamassageBleu joueur;
    public AudioSource audioSource;
    public AudioClip sonTermine;

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
        texte.text = "Verres restants : " + restant;

        if (restant == 0 && joueur.objetTenu == null && !sonJoue)
        {
            JouerSon();
            GestionTri.AjouterSiTermine(tagAliment);
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
