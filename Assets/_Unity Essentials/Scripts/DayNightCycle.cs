using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The number of real-time seconds it takes for a full 360° rotation (one full day).")]
    [SerializeField] private float dayLengthInSeconds = 120f; // Default: 2 minutes for a full day

    private void Update()
    {
        // Calculate how much to rotate this frame
        float rotationThisFrame = 360f / dayLengthInSeconds * Time.deltaTime;

        // Apply the rotation around the X-axis
        transform.Rotate(Vector3.right, rotationThisFrame);
    }
}
