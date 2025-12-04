using UnityEngine;

public class BB_Respawner : MonoBehaviour
{
    public Transform vrCamera;        // CenterEyeAnchor
    public Transform respawnPoint;    // Respawn location
    public float fallThreshold = 0f;  // Adjust as needed

    void Update()
    {
        if (vrCamera.position.y < fallThreshold)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Teleport the entire rig root
        transform.position = respawnPoint.position;
    }
}
