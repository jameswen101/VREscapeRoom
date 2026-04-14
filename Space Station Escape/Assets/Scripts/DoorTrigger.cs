using UnityEngine;

public class DoorTrigger : MonoBehaviour

{
    public Animator doorAnimator;
    public Animator doorAnimator2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mars"))
        {

            Debug.Log("girdi");
            doorAnimator.enabled = true;
            doorAnimator2.enabled = true;   
            Destroy(other.gameObject);
        }
    }
}