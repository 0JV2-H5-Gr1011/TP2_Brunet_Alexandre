using UnityEngine;

public class RamassageBleu : MonoBehaviour
{
    public float distanceRamassage = 3f;
    public bool tientObjet = false;
    public GameObject objetTenu;
    public AudioSource audioSource;
    public AudioClip sonDisparition;

    void Update()
    {
        if (tientObjet) return;

        GameObject objetProche = TrouverObjetProche();

        if (objetProche != null && Input.GetKeyDown(KeyCode.E))
        {
            tientObjet = true;
            objetTenu = objetProche;
            if (audioSource && sonDisparition)
            {
                audioSource.clip = sonDisparition;
                audioSource.Play();
            }
            objetProche.SetActive(false);
        }
    }

    GameObject TrouverObjetProche()
    {
        GameObject[] objets = GameObject.FindGameObjectsWithTag("Verre");
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
