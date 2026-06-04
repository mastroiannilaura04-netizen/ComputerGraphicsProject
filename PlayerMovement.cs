using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftControl))
{
    transform.localScale = new Vector3(1, 0.5f, 1);
}
else
{
    transform.localScale = new Vector3(1, 1, 1);
}
        if (Input.GetKey(KeyCode.LeftControl))
{
    controller.height = 1f;
}
else
{
    controller.height = 2f;
}
    }
}