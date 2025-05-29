using UnityEngine;

public class RamassageCompost : MonoBehaviour
{
    public float distanceRamassage = 3f;
    public bool tientObjet = false;
    public GameObject objetTenu;

    void Update()
    {
        if (tientObjet) return;

        GameObject objetProche = TrouverObjetProche();

        if (objetProche != null && Input.GetKeyDown(KeyCode.E))
        {
            tientObjet = true;
            objetTenu = objetProche;
            objetProche.SetActive(false);
        }
    }

    GameObject TrouverObjetProche()
    {
        GameObject[] objets = GameObject.FindGameObjectsWithTag("Compost");
        GameObject objetLePlusProche = null;
        float distanceMin = distanceRamassage;

        foreach (GameObject obj in objets)
        {
            float dist = Vector3.Distance(transform.position, obj.transform.position);
            if (dist <= distanceMin)
            {
                objetLePlusProche = obj;
                distanceMin = dist;
            }
        }
        return objetLePlusProche;
    }
}
