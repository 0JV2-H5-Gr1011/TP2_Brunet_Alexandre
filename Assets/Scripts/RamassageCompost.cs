using UnityEngine;

public class RamassageCompost : MonoBehaviour
{
    public float distanceRamassage = 3f;
    public bool tientObjet = false;
    private GameObject objetTenu;

    void Update()
    {
        if (tientObjet) return;

        GameObject plusProche = TrouverObjetPlusProche();
        if (plusProche != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                tientObjet = true;
                objetTenu = plusProche;
                plusProche.SetActive(false);
            }
        }
    }

    GameObject TrouverObjetPlusProche()
    {
        GameObject[] objets = GameObject.FindGameObjectsWithTag("Compost");
        GameObject plusProche = null;
        float distanceMin = distanceRamassage;

        foreach (GameObject obj in objets)
        {
            float dist = Vector3.Distance(transform.position, obj.transform.position);
            if (dist <= distanceMin)
            {
                plusProche = obj;
                distanceMin = dist;
            }
        }
        return plusProche;
    }
}
