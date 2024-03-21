using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemiesLeftDisplay : MonoBehaviour
{
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(displayText != null)
        {
            displayText.text = "Enemies: " + gameManager.DecrementEnemiesRemain().ToString();
        }
    }
    // Start is called before the first frame update
//    public void DisplayEnemiesLeft()
//     {
//         if (displayText != null)
//         {
//             displayText.text = "Enemies: " + GameManager.DecrementEnemiesRemain.ToString();
//         }
//     }

//     // Update is called once per frame
//    public void UpdateUI()
//     {
    
//         base.UpdateUI();
//         // The remaining code is only called for this sub-class of UIelement and not others
//         DisplayEnemiesLeft();
//     }
}
