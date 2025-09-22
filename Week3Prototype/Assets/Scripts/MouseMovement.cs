using Unity.VisualScripting;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float lerpTime = 0.5f;

    public void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, mousePosition, lerpTime * Time.deltaTime);
    }
}
