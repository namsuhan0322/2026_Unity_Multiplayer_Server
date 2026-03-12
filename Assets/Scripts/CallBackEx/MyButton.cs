using UnityEngine;
using System;

public class MyButton : MonoBehaviour
{
    public Action OnPressed;                                // 버튼 눌림 액션을 선언 한.

    private bool canPress = true;

    void Update()
    {
        if (!canPress) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Button Pressed!");
            canPress = false;
            OnPressed.Invoke();                             // 버튼이 눌리면 Action을 호출 한다.
        }
    }
}
