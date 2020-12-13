using UnityEngine;

public class ActionsControls : MonoBehaviour
{
    public bool Drag { get; set; }
    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Drag = true;
        }
        else
        {
            Drag = false;
        }
    }
}
