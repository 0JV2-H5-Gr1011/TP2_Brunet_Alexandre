using UnityEngine;

public class RamassageTri : MonoBehaviour
{
    public float distanceRamassage = 3f;
    public bool tientObjet = false;
    public GameObject objetTenu;
    public AudioSource audioSource;
    public AudioClip sonRamassage;

    void Update()
    {
        if (tientObjet) return;

        GameObject proche = TrouverObjetProche();

        if (proche != null && Input.GetKeyDown(KeyCode.E))
        {
            tientObjet = true;
            objetTenu = proche;
            if (audioSource && sonRamassage)
                audioSource.PlayOneShot(sonRamassage);
            proche.SetActive(false);
        }
    }

    GameObject TrouverObjetProche()
    {
        string[] tags = { "Nourriture", "Carton", "Verre" };
        GameObject cible = null;
        float minDist = distanceRamassage;

        foreach (string tag in tags)
        {
            GameObject[] objets = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject obj in objets)
            {
                float dist = Vector3.Distance(transform.position, obj.transform.position);
                if (dist < minDist)
                {
                    cible = obj;
                    minDist = dist;
                }
            }
        }
        return cible;
    }
}
