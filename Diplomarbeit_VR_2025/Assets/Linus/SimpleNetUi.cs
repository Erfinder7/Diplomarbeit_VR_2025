using Unity.Netcode;
using UnityEngine;

public class SimpleNetUI : MonoBehaviour
{
    public GameObject menuCanvas; // hier kommt dein Canvas rein (optional)

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        if (menuCanvas != null) menuCanvas.SetActive(false);
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        if (menuCanvas != null) menuCanvas.SetActive(false);
    }
}
