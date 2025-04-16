using UnityEngine;

[RequireComponent(typeof(Light))]
public class RedFlashingLight : MonoBehaviour
{
    public float flashRate = 0.5f; // Time between flashes (in seconds)

    private Light flashingLight;
    private float flashTimer = 0f;

    void Start()
    {
        // Get or add a Light component
        flashingLight = GetComponent<Light>();

        // Configure the light
        flashingLight.color = Color.red;
        flashingLight.intensity = 2f;
        flashingLight.range = 10f;
        flashingLight.enabled = true;
    }

    void Update()
    {
        flashTimer += Time.deltaTime;
        if (flashTimer >= flashRate)
        {
            flashingLight.enabled = !flashingLight.enabled;
            flashTimer = 0f;
        }
    }
}
