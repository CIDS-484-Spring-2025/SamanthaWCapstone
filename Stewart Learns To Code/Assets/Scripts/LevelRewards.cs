using UnityEngine;

public class LevelRewards : MonoBehaviour
{
    public static int lessonOneHat;
    public static int lessonTwoHat;
    public static int lessonThreeHat;

    public GameObject lOneReward;
    public GameObject lTwoReward;
    public GameObject lThreeReward;

    void Update()
    {
        if(lessonOneHat == 1)
        {
           lOneReward.SetActive(true);
        }
        if(lessonTwoHat == 1)
        {
           lTwoReward.SetActive(true);
        }
        if(lessonThreeHat == 1)
        {
           lThreeReward.SetActive(true);
        }
        
    }
}
