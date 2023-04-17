using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum STATS
{
    HUNGRY, CLEAN, HAPPY
}
public class TamagochiManager : MonoBehaviour
{
    public float hungry, hungryThreshold = 10;
    public float clean, cleanThreshold = 10;
    public float happy, happyThreshold = 10;
    public static TamagochiManager instance;

    public Image barHungry, barClean, barHappy;
    private void Update()
    {
        barHungry.fillAmount = hungry / hungryThreshold;
        barClean.fillAmount= clean / cleanThreshold;
        barHappy.fillAmount = happy/ happyThreshold;
    }
    private void Awake()
    {
        instance= this;
    }
    private void Feed(float amount)
    {
        hungry+= amount;
        if(hungry > hungryThreshold) 
        {
            hungry = hungryThreshold;
        }
    }
    private void Clean(float amount)
    {
        clean += amount;
        if (clean > cleanThreshold)
        {
            clean = cleanThreshold;
        }
    }
    private void Happy(float amount)
    {
        happy += amount;
        if (happy > happyThreshold)
        {
            happy = happyThreshold;
        }
    }

    public void ChangeStat(STATS stats, float amount)
    {
        switch(stats)
        {
            case STATS.HUNGRY:
                Feed(amount);
                break;
            case STATS.CLEAN:
                Clean(amount);
                break;
            case STATS.HAPPY:
                Happy(amount);
                break;
        }
    }

}
