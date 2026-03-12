using System;
using UnityEngine;

public class MyDoor : MonoBehaviour
{
    [SerializeField] private MyButton button;
    private bool isOpen = false;

    void Start()
    {
        button.OnPressed += OpenDoor;
    }

    private void OpenDoor()
    {
        if (isOpen) return;

        isOpen = true;
        Debug.Log("Door Opened!");
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
