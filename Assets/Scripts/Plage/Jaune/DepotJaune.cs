using UnityEngine;

public class DepotJaune : MonoBehaviour
{
    public RamassageJaune joueur;
    public float distanceDepot = 3f;
    public Transform couvercle;
    public AudioSource audioSource;
    public AudioClip sonOuverture;
    public AudioClip sonFermeture;
    public float vitesseOuverture = 2f;

    bool ouvert = false;
    bool sonOuvertureJoue = false;
    bool sonFermetureJoue = false;

    Quaternion rotationOuverte = Quaternion.Euler(-40f, 0f, 0f);
    Quaternion rotationFermee = Quaternion.Euler(0f, 0f, 0f);

    void Update()
    {
        float dist = Vector3.Distance(joueur.transform.position, transform.position);
        bool procheEtTient = dist <= distanceDepot && joueur.tientObjet;

        if (procheEtTient)
        {
            if (!ouvert)
            {
                ouvert = true;
                sonOuvertureJoue = false;
                sonFermetureJoue = false;
            }

            Quaternion rotationAvant = couvercle.localRotation;

            couvercle.localRotation = Quaternion.RotateTowards(
                couvercle.localRotation,
                rotationOuverte,
                vitesseOuverture * Time.deltaTime * 100);

            if (!sonOuvertureJoue && audioSource && sonOuverture && Quaternion.Angle(rotationAvant, couvercle.localRotation) > 0.1f)
            {
                audioSource.clip = sonOuverture;
                audioSource.Play();
                sonOuvertureJoue = true;
                sonFermetureJoue = false;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                joueur.tientObjet = false;
                joueur.objetTenu = null;
                ouvert = false;
                sonOuvertureJoue = false;
                sonFermetureJoue = false;
            }
        }
        else
        {
            if (ouvert)
            {
                ouvert = false;
                sonOuvertureJoue = false;
                sonFermetureJoue = false;
            }

            Quaternion rotationAvant = couvercle.localRotation;

            couvercle.localRotation = Quaternion.RotateTowards(
                couvercle.localRotation,
                rotationFermee,
                vitesseOuverture * Time.deltaTime * 100);

            if (!sonFermetureJoue && audioSource && sonFermeture && Quaternion.Angle(rotationAvant, couvercle.localRotation) > 0.1f)
            {
                audioSource.clip = sonFermeture;
                audioSource.Play();
                sonFermetureJoue = true;
                sonOuvertureJoue = false;
            }
        }
    }
}
