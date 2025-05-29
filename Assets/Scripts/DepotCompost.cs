using UnityEngine;

public class DepotCompost : MonoBehaviour
{
    public Transform couvercle;
    public float distanceDepot = 3f;
    public Transform joueur;
    public RamassageCompost ramassage;

    private float rotationOuverte = -40f;
    private float rotationFermee = 0f;
    private float vitesseRotation = 2f;

    void Update()
    {
        float dist = Vector3.Distance(joueur.position, transform.position);
        bool proche = dist <= distanceDepot;

        if (proche && ramassage.tientObjet)
        {
            Vector3 rotationTarget = new Vector3(rotationOuverte, 0, 0);
            couvercle.localRotation = Quaternion.Slerp(couvercle.localRotation, Quaternion.Euler(rotationTarget), Time.deltaTime * vitesseRotation);

            if (Input.GetKeyDown(KeyCode.E))
            {
                ramassage.tientObjet = false;
                if (ramassage.objetTenu != null)
                {
                    Destroy(ramassage.objetTenu);
                    ramassage.objetTenu = null;
                }
            }
        }
        else
        {
            Vector3 rotationTarget = new Vector3(rotationFermee, 0, 0);
            couvercle.localRotation = Quaternion.Slerp(couvercle.localRotation, Quaternion.Euler(rotationTarget), Time.deltaTime * vitesseRotation);
        }
    }
}
