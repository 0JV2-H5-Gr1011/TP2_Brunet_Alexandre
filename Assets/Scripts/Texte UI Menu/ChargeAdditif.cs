using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeAdditif : MonoBehaviour
{
    [SerializeField] private string scene;

    void Start()
    {
        if (!string.IsNullOrEmpty(scene))
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
    }
}
