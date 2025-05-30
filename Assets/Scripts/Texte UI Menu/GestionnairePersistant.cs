using UnityEngine;

public class GestionnairePersistant : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
