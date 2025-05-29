using UnityEngine;
using TMPro;

public class PointsRestants : MonoBehaviour
{
    public string tagPoints = "Point";
    public TextMeshProUGUI texte;
    public AudioSource audioSource;
    public AudioClip sonTermine;
    public Minuteur3Minutes minuteur;

    private bool sonJoue = false;
    private bool minuteurDemarre = false;

    void Start()
    {
        texte.fontSize = 46;
        texte.fontStyle = FontStyles.Bold;
        texte.color = new Color(1f, 0.4f, 0.4f);
        texte.enableWordWrapping = false;
    }

    void Update()
    {
        int restant = GameObject.FindGameObjectsWithTag(tagPoints).Length;
        texte.text = "Points restants : " + restant;

        if (restant == 0)
        {
            if (!sonJoue)
            {
                JouerSon();
                sonJoue = true;
            }

            if (!minuteurDemarre && minuteur != null)
            {
                minuteur.tempsRestant = 0f;
                minuteur.minuterEnCours = true;
                minuteurDemarre = true;
            }
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
