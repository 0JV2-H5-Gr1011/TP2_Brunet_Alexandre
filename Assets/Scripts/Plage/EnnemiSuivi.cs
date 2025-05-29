using UnityEngine;
using UnityEngine.AI;

public class EnnemiSuivi : MonoBehaviour
{
    public Transform cible;
    public NavMeshAgent agent;
    public float delaiCollision = 2f;

    Transform positionDepartJoueur;
    float dernierContact = -999f;

    void Start()
    {
        if (agent == null)
            agent = GetComponent<NavMeshAgent>();

        if (cible != null)
        {
            GameObject vide = new GameObject("DepartJoueur");
            vide.transform.position = cible.position;
            positionDepartJoueur = vide.transform;
        }
    }

    void Update()
    {
        if (cible != null)
            agent.SetDestination(cible.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Time.time - dernierContact >= delaiCollision)
        {
            GameObject[] points = GameObject.FindGameObjectsWithTag("Point");
            if (points.Length > 0)
            {
                int index = Random.Range(0, points.Length);
                Destroy(points[index]);
            }

            if (positionDepartJoueur != null)
                other.transform.position = positionDepartJoueur.position;

            dernierContact = Time.time;
        }
    }
}
