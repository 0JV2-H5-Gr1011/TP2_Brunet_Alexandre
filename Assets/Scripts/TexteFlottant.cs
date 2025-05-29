using UnityEngine;

public class TexteFlottant : MonoBehaviour
{
    private Vector3 posDepart;
    public GameObject objetLie;

    void Start()
    {
        posDepart = transform.position;
    }

    void Update()
    {
        if (objetLie == null || !objetLie.activeInHierarchy)
        {
            Destroy(gameObject);
            return;
        }

        float offset = Mathf.Sin(Time.time * 2f) * 0.2f;
        transform.position = new Vector3(posDepart.x, posDepart.y + offset, posDepart.z);
    }
}
