using UnityEngine;
using UnityEngine.SceneManagement;

public class PorteChangement : MonoBehaviour
{
    public Transform joueur;
    public float distanceActivation = 3f;
    public string tagAliment = "Compost";
    public string nomScene = "Plage";

    void Update()
    {
        int restant = GameObject.FindGameObjectsWithTag(tagAliment).Length;
        float distance = Vector3.Distance(joueur.position, transform.position);

        if (restant == 0 && distance <= distanceActivation && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(nomScene);
        }
    }
}
