using UnityEngine;

public class DefaultPrinter : MonoBehaviour
{
    [SerializeField] private string textToPrint;

    void Start()
    {
        print(textToPrint);
    }
}