using UnityEngine;

public class EnergyRoomPuzzle2 : MonoBehaviour
{
    public Animator doorAnimator;

    private string[] correctOrder = { "Oliver", "Paul", "Ethan", "Nash" };
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
            other.CompareTag("Oliver") ||
            other.CompareTag("Paul") ||
            other.CompareTag("Ethan") ||
            other.CompareTag("Nash"))
        {
            Debug.Log("Wrong order: " + other.tag);
        }
    }
}

