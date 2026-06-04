using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light targetLight;
    public float interactionDistance = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float distance = Vector3.Distance(transform.position, targetLight.transform.position);

            if (distance <= interactionDistance)
            {
                targetLight.enabled = !targetLight.enabled;
            }
        }
    }
}