using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Vector2 hotspot = Vector2.zero; // Punto attivo del cursore
    public CursorMode cursorMode = CursorMode.Auto;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotspot, cursorMode);
    }
}