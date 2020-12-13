using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private IControllable playerControls;

    [HideInInspector] public Vector2 movementVector;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerControls = GetComponent<IControllable>();
        movementVector = new Vector2(playerControls.Horizontal, playerControls.Vertical);
    }

    private void FixedUpdate()
    {
        movementVector = new Vector2(playerControls.Horizontal, playerControls.Vertical);

        if (playerControls is MouseControls)
            rigidbody.MovePosition(movementVector);
        else if (playerControls is KeyboardControls)
            rigidbody.velocity = movementVector * Time.fixedDeltaTime;
    }
}
