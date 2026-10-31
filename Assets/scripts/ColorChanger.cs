using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer rend;
    public Color selectColor = Color.red;
    private Color originalColor;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        if (rend != null) originalColor = rend.material.color;
    }

    public void OnSelectEntered()
    {
        if (rend != null) {
            rend.material.color = selectColor;
        }
    }

    public void OnSelectExited()
    {
        if (rend != null) {
            rend.material.color = originalColor;
        }
    }
}