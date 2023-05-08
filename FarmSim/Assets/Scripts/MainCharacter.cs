using UnityEngine;

public class MainCharacter : MonoBehaviour
{

    private int points = 0;
    public MainCharacter player;
 



    public void AddPoints(int amount)
    {
        points += amount;
    }


    //public void SubtractPoints(int amount)
    //{
    //    points -= amount;


    //    if (points < 0)
    //    {
    //        points = 0;
    //    }
    //}


    //public int GetPoints()
    //{
    //    return points;
    //}
}
