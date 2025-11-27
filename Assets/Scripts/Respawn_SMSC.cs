using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn_SMSC : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Main Menu");
    }
} //"android sdk not found" who invited this guy
