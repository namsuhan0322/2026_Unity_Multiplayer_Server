using UnityEngine;

public class Monster : MonoBehaviour
{
    public IQuestCallBacks callBacks;
    private bool isDead = false;

    void Update()
    {
        if (isDead) return;
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            isDead = true;
            Debug.Log("Monster Killed!");
            callBacks?.OnMonsterKilled("슬라임");
            gameObject.SetActive(false);
        }
    }
}
