using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    public SauvegardeTexte gestionTexte;

    public void ChargerScene(string nomScene)
    {
        gestionTexte.SauvegarderTexte(); // Save properly before switching scenes
        SceneManager.LoadScene(nomScene);
    }
}
