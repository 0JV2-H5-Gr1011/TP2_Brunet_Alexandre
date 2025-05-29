using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string sceneACharger;

    public void ChargerScene()
    {
        SceneManager.LoadScene(sceneACharger);
    }
}
