using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    // This variable tracks the main character's points
    private int points = 0;

    // This function is called to add points to the main character
    public void AddPoints(int amount)
    {
        points += amount;
    }

    // This function is called to subtract points from the main character
    public void SubtractPoints(int amount)
    {
        points -= amount;

        // Ensure the main character never has negative points
        if (points < 0)
        {
            points = 0;
        }
    }

    // This function is called to get the main character's current points
    public int GetPoints()
    {
        return points;
    }
}
