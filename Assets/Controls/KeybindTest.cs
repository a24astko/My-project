using UnityEngine;
using UnityEngine.InputSystem;

public class KEYBIND : MonoBehaviour
{
    public InputActionAsset PlayerAction;
    public Animator epicAnimator;

    // Update is called once per frame
    void Update()
    {
        if (PlayerAction.FindAction("Move").IsPressed())
        {
            epicAnimator.SetBool("Running", true);
        }
        else
            epicAnimator.SetBool("Running", false);

        if (PlayerAction.FindAction("Jump").IsPressed())
        {
            epicAnimator.SetBool("Jumping", true);
        }
        else
            epicAnimator.SetBool("Jumping", false);
    }
}