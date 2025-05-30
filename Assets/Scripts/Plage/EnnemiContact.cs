using UnityEngine;

public class EnnemiContact : MonoBehaviour
{
    public Transform cible;
    public float delaiCollision = 2f;
    public AudioSource audioSource;
    public AudioClip sonCollision;

    private float dernierContact = -999f;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == cible && Time.time - dernierContact >= delaiCollision)
        {
            GameObject[] points = GameObject.FindGameObjectsWithTag("Point");
            if (points.Length > 0)
            {
                int index = Random.Range(0, points.Length);
                Destroy(points[index]);
            }

            if (audioSource && sonCollision)
                audioSource.PlayOneShot(sonCollision);

            dernierContact = Time.time;
        }
    }
}
