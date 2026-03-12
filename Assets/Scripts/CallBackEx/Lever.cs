using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent OnPulled;

    private bool isUsed = false;

    void Update()
    {
        if (isUsed) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            isUsed = true;
            Debug.Log("Lever pulled!");
            OnPulled.Invoke();
        }
    }
}
