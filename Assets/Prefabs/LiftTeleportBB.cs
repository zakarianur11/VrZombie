using UnityEngine;

public class LiftTeleportBB : MonoBehaviour
{
    [Header("Assign the root of your Building Blocks Camera Rig")]
    public Transform playerRig;

    [Header("Where the player should appear (eye level already considered)")]
    public Transform liftTopPoint;

    [Header("Seconds to wait before teleporting")]
    public float delay = 2f;

    private bool triggered = false;
    private CharacterController controller;

    private void Start()
    {
        controller = playerRig.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
        {
            triggered = true;
            StartCoroutine(TeleportAfterDelay());
        }
    }

    private System.Collections.IEnumerator TeleportAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        // Disable CharacterController so we can safely move the rig
        if (controller != null) controller.enabled = false;

        // Move the entire rig directly to the liftTopPoint
        playerRig.position = liftTopPoint.position;

        // Re-enable CharacterController
        if (controller != null) controller.enabled = true;
    }
}
