using UnityEngine;

public class TeleportDoor : MonoBehaviour
{
    public Transform player;
    public Transform destination;
    public float distance = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float d = Vector3.Distance(player.position, transform.position);

            if (d <= distance)
            {
                CharacterController cc = player.GetComponent<CharacterController>();

                if (cc != null)
                    cc.enabled = false;

                player.position = destination.position;

                if (cc != null)
                    cc.enabled = true;
            }
        }
    }
}