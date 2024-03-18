using UnityEngine;

public class PuzzleControl : MonoBehaviour
{
    public int correctRotations = 0; // Variable to track correct rotations
    public Animator mouseAnimator; // Animator for the character2 animation

    void Start()
    {
        // Ensure the animators are not null at the start
        if (mouseAnimator == null)
        {
            Debug.LogError("Student Animators are not assigned to PuzzleControl.");
        }
        else
        {
            // Disable the current animation
            mouseAnimator.enabled = false;
        }
    }

    public void PuzzleEnd()
    {
        // Increase the number of correct rotations
        correctRotations++;

        // Check if all required rotations are completed
        if (correctRotations >= 20) // Check if animation has not been played before
        {
            // Play the animation
            mouseAnimator.enabled = true;
        }
    }
}
