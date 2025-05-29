using UnityEngine;

public class GestionPoints : MonoBehaviour
{
    public string tagPoints = "Point";
    private int pointsRestants;

    void Start()
    {
        pointsRestants = GameObject.FindGameObjectsWithTag(tagPoints).Length;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagPoints))
        {
            pointsRestants--;
            Destroy(other.gameObject);
        }
    }

    public int GetPointsRestants()
    {
        return pointsRestants;
    }
}
