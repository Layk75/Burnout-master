using UnityEngine;
using UnityEngine.UI;

public class StressBarManager : MonoBehaviour
{
    public Slider stressBar;  // Drag the Slider here from the Inspector
    public float stressDuration = 180f;  // 3 minutes = 180 seconds
    private float stressTimeLeft;

    void Start()
    {
        // Start with the stress bar full (3 minutes)
        stressTimeLeft = stressDuration;
        stressBar.maxValue = stressDuration;
        stressBar.value = stressDuration;
    }

    void Update()
    {
        // Decrease the time left gradually
        if (stressTimeLeft > 0)
        {
            stressTimeLeft -= Time.deltaTime;  // Subtract the elapsed time each frame
            stressBar.value = stressTimeLeft;  // Update the slider's value to reflect time left
        }
        else
        {
            stressBar.value = 0f;  // When time runs out, the bar is empty
        }
    }

    void Awake()
    {
        // Ensure the stress bar persists across scenes
        DontDestroyOnLoad(this.gameObject);
    }
}
