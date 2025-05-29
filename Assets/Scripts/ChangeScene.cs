using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    [SerializeField] private string sceneACharger;
    [SerializeField] private string sceneASupprimer;

    public void ChargerScene()
    {
        SceneManager.LoadScene(sceneACharger, LoadSceneMode.Additive);  
        SceneManager.UnloadSceneAsync(sceneASupprimer);
    }
}
