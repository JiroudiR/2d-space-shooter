using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// This class inherits for the UIelement class and handles updating the score display
/// </summary>
public class ScoreDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public TMP_Text displayText = null;
    public TMP_Text strikeText = null;

    /// <summary>
    /// Description:
    /// Updates the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayScore()
    {
        if (displayText != null)
        {
            int enemiesLeft = GameManager.instance.enemiesToDefeat - GameManager.instance.enemiesDefeated;
            displayText.text = "Martians Left: " + enemiesLeft.ToString();
        }
    }

    public void DisplayStrikes()
    {
        int strikeScore = 3;
        if (strikeText != null)
        {
            
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                strikeScore = 3;
            } else if (SceneManager.GetActiveScene().name == "Level2")
            {
                strikeScore = 2;
            } else if (SceneManager.GetActiveScene().name == "Level3")
            {
                strikeScore = 1;
            }
            int strikeTotal = strikeScore - GameManager.instance.enemiesMissed;
            strikeText.text = "Strikes Left: " + strikeTotal.ToString();
        }
    }

    /// <summary>
    /// Description:
    /// Overides the virtual UpdateUI function and uses the DisplayScore to update the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayScore();
        DisplayStrikes();
    }
}
