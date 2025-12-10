using UnityEngine;
using UnityEngine.EventSystems;

public class SceneGo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float pressDepth = 0.05f;     // Wie tief der Button einsinkt
    public float animationSpeed = 10f;   // Geschwindigkeit der Rückkehr

    private Vector3 originalPosition;
    private Vector3 pressedPosition;
    private bool isPressed = false;

    private void Start()
    {
        originalPosition = transform.localPosition;
        pressedPosition = originalPosition - new Vector3(0, pressDepth, 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        transform.localPosition = pressedPosition;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    private void Update()
    {
        if (!isPressed)
        {
            // Sanft zurück zur Ausgangsposition gleiten
            transform.localPosition = Vector3.Lerp(
                transform.localPosition,
                originalPosition,
                Time.deltaTime * animationSpeed
            );
        }
    }
}
