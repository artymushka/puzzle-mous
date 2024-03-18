using UnityEngine;
using UnityEngine.EventSystems;

public class RotatePuzzle : MonoBehaviour, IPointerClickHandler
{
    public int rotationsNeeded = 4; // Number of 90-degree rotations needed    

    private bool isRotating = true; // Variable to determine if rotations can be performed

    public PuzzleControl puzzleControl; // Reference to the PuzzleManager script

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicks");
        // Check if rotations can be performed
        if (isRotating)
        {
            RotateImage();
        }
    }

    private void RotateImage()
    {

        // Rotate the clicked puzzle piece by 90 degrees
        transform.Rotate(0f, 0f, 90f);

        // Decrease the number of remaining rotations
        rotationsNeeded--;

        // Check if all required rotations are completed
        if (rotationsNeeded <= 0)
        {
            isRotating = false; // Disable additional rotations
            puzzleControl.PuzzleEnd();
        }
    }
}