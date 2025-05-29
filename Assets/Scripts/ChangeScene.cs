using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    [SerializeField] private string sceneACharger;
    [SerializeField] private GameObject sceneAMasquer;

    public void ChargerScene()
    {
        SceneManager.LoadScene(sceneACharger, LoadSceneMode.Additive);

        if (sceneAMasquer != null)
        {
            sceneAMasquer.SetActive(false);
        }
    }
}
