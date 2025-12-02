using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{
    // Height threshold below which we consider the player fallen
    [SerializeField] private float fallThreshold = -10f;
    public Transform TargetPosition;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
        TeleportToTarget();
    }

    private void TeleportToTarget()
    {
        this.transform.position = TargetPosition.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TeleportToTarget();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is MainStructure
        if (other.CompareTag("Target"))
        {
            TeleportToTarget();
        }
    }
}