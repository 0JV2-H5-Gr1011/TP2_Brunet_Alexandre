using UnityEngine;

public class ObjetLevitant : MonoBehaviour
{
    [SerializeField] private float vitesseRotation = 20f;
    [SerializeField] private float intensiteLumiere = 0.1f;
    [SerializeField] private float amplitudeLevitation = 0.5f;
    [SerializeField] private float frequenceLevitation = 2f;
    [SerializeField] private float rayonLumiere = 10f;

    private Vector3 posDepart;
    private Light lumiere;

    void Start()
    {
        posDepart = transform.position;
        lumiere = gameObject.AddComponent<Light>();
        lumiere.type = LightType.Point;
        lumiere.color = Color.cyan;
        lumiere.range = rayonLumiere;
        lumiere.intensity = intensiteLumiere;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * frequenceLevitation) * amplitudeLevitation;
        transform.position = new Vector3(posDepart.x, posDepart.y + offset, posDepart.z);
        transform.Rotate(0, vitesseRotation * Time.deltaTime, 0);
        lumiere.intensity = intensiteLumiere;
    }
}
