using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableObject_table : MonoBehaviour
{
    private bool isClickable = true;

    private void OnMouseDown()
    {
        if (isClickable)
        {
            // Set the flag to indicate we are transitioning to another scene
            PlayerPrefs.SetInt("ReturningFromTable", 1);

            // Load Scene2
            SceneManager.LoadScene("minigames_table");
        }
    }

    public void SetClickable(bool clickable)
    {
        isClickable = clickable;
    }
}

