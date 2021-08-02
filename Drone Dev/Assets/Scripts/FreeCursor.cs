using UnityEngine;

public class FreeCursor : MonoBehaviour
{

    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
