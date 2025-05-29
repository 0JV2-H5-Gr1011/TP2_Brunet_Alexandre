using UnityEngine;

public class LevitationObjet : MonoBehaviour
{
    private Vector3 posDepart;
    private Light lumiere;

    void Start()
    {
        posDepart = transform.position;
        lumiere = gameObject.AddComponent<Light>();
        lumiere.type = LightType.Point;
        lumiere.color = Color.cyan;
        lumiere.range = 2f;
        lumiere.intensity = 0.1f;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * 2f) * 0.2f;
        transform.position = new Vector3(posDepart.x, posDepart.y + offset, posDepart.z);
        transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
