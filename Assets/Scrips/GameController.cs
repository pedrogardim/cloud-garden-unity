using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int sunPoints = 0;
    public Text sunPointsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        sunPointsText.text = sunPoints.ToString();
    }
     public void addSun(int amount)
    {
        sunPoints += amount;
    }
}
