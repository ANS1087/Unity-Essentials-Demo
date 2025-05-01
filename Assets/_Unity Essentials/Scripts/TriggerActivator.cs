using UnityEngine;

public class TriggerActivator : MonoBehaviour
{
    [Tooltip("Reference to the Ball GameObject with a Rigidbody.")]
    [SerializeField] private Rigidbody ballRigidbody;

    private void OnTriggerEnter(Collider other)
    {
        // You can add checks here if you want to be specific (e.g., tag checks)

        if (ballRigidbody != null)
        {
            ballRigidbody.useGravity = true;
        }
        else
        {
            Debug.LogWarning("Ball Rigidbody reference is missing!");
        }
    }
}
