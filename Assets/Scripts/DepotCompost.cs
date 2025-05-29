using UnityEngine;

public class DepotCompost : MonoBehaviour
{
    public RamassageCompost joueur;
    public float distanceDepot = 3f;
    public Transform couvercle;
    public AudioSource sonCouvercle;
    public AudioClip sonOuverture;

    private bool ouvert = false;

    void Update()
    {
        float dist = Vector3.Distance(joueur.transform.position, transform.position);

        if (dist <= distanceDepot && joueur.tientObjet)
        {
            if (!ouvert)
            {
                couvercle.localRotation = Quaternion.Euler(-40f, 0f, 0f);
                if (sonCouvercle && sonOuverture) sonCouvercle.PlayOneShot(sonOuverture);
                ouvert = true;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                joueur.tientObjet = false;
                joueur.objetTenu = null;
                couvercle.localRotation = Quaternion.Euler(0f, 0f, 0f);
                ouvert = false;
            }
        }
        else
        {
            if (ouvert)
            {
                couvercle.localRotation = Quaternion.Euler(0f, 0f, 0f);
                ouvert = false;
            }
        }
    }
}
