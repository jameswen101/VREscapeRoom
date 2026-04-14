using UnityEngine;

public class EnergyRoomPuzzle : MonoBehaviour
{
    public Animator doorAnimator;

    private string[] correctOrder = { "Red", "Yellow", "Green", "Blue" };
    private int currentIndex = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (currentIndex >= correctOrder.Length) return;

        if (other.CompareTag(correctOrder[currentIndex]))
        {
            Debug.Log("Correct: " + correctOrder[currentIndex]);

            Destroy(other.gameObject);
            currentIndex++;

            if (currentIndex >= correctOrder.Length)
            {
                Debug.Log("Sequence complete. Door opened.");
                doorAnimator.enabled = true;
            }
        }
        else if (
            other.CompareTag("Red") ||
            other.CompareTag("Yellow") ||
            other.CompareTag("Green") ||
            other.CompareTag("Blue"))
        {
            Debug.Log("Wrong order: " + other.tag);
        }
    }
}

