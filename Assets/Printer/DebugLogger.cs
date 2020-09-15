using UnityEngine;

public class DebugLogger : MonoBehaviour
{
    [SerializeField] private string textToPrint;

    void Start()
    {
        Debug.Log(textToPrint);
    }
}