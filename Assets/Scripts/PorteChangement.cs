using UnityEngine;
using UnityEngine.SceneManagement;

public class PorteChangement : MonoBehaviour
{
    public Transform joueur;
    public float distanceActivation = 3f;
    public string tagAliment = "Compost";

    bool sceneChargee = false;

    void Update()
    {
        int restant = GameObject.FindGameObjectsWithTag(tagAliment).Length;
        float dist = Vector3.Distance(joueur.position, transform.position);

        if (restant == 0 && dist <= distanceActivation && !sceneChargee && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Plage", LoadSceneMode.Additive);
            sceneChargee = true;
        }
    }
}
