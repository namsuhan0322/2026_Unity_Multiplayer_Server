using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    private bool isOpen = false;

    public void OpenChest()
    {
        if (isOpen) return;
        isOpen = true;
        Debug.Log("Treasure Chest Opened! You found a rare item!");
        transform.rotation = Quaternion.Euler(-30f, 0f, 0f);
    }
}
