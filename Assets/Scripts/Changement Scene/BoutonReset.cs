using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonReset : MonoBehaviour
{
    public string nomSceneDepart = "SceneDepart";

    public void Reinitialiser()
    {
        SceneManager.LoadScene(nomSceneDepart);
    }
}
