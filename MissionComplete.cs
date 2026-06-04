using UnityEngine;


public class MissionComplete : MonoBehaviour
{
    public GameObject missionText;
    public Renderer computerScreen;
    public Material computerOnMaterial;
    public Light serverLight;
    public float distance = 3f;
    public Light[] facilityLights;
    public Color activatedColor = Color.cyan;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject player = GameObject.Find("Player");

            if (Vector3.Distance(player.transform.position, transform.position) < distance)
            {
                missionText.SetActive(true);

                if (computerScreen != null && computerOnMaterial != null)
                    computerScreen.material = computerOnMaterial;

                if (serverLight != null)
                    serverLight.enabled = true;

                    foreach (Light l in facilityLights)
{
    if (l != null)
        l.color = activatedColor;
}
            }
        }
    }
}