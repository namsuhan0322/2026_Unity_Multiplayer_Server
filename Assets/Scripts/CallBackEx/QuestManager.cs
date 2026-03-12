using UnityEngine;

public class QuestManager : MonoBehaviour, IQuestCallBacks
{
    [SerializeField] private Monster monster;
    private int killCount = 0;

    void Start()
    {
        monster.callBacks = this;                           
    }

    public void OnMonsterKilled(string monsterName) 
    {
        killCount++;
        Debug.Log($"{monsterName} Total kills: {killCount}");

        if (killCount > 0)
        {
            Debug.Log("퀘스트 완료");
        }
    }
}
