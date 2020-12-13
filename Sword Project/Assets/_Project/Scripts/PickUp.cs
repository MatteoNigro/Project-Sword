using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private ActionsControls playerActions;
    [SerializeField] private GameObject pickUpPoint;
    private Rigidbody2D rigidbody;
    private bool canPickUp;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (playerActions.Drag && canPickUp)
        {
            // SET THE INTENSITY OF THE DRAG CALCULATING THE SPEED BASED ON THE DISTANCE FROM THE PARENT (SEE VIDEO ON YOUTUBE)
            Vector2 parentPosition = new Vector2(pickUpPoint.transform.position.x, pickUpPoint.transform.position.y);
            Vector2 dragDirection = parentPosition - rigidbody.position;
            rigidbody.velocity = dragDirection.normalized * 2;
            //rigidbody.position = pickUpPoint.transform.position;
            transform.SetParent(pickUpPoint.transform);
            rigidbody.gravityScale = 0;
        }
        else
        {
            transform.SetParent(null);
            rigidbody.gravityScale = 1;
            canPickUp = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("DragPoint"))
            canPickUp = true;

    }
}
