using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardSpawn : MonoBehaviour {
    
    public List<GameObject> rewards = new List<GameObject>();


    private void Start()
    {
        InvokeRepeating("SpawnReward", 5, 8);
    }

    private void Update()
    {
        if (GameOverText.gameOver == true || WinText.completeLevel == true)
        {
            CancelInvoke("SpawnReward");
        }
    }


    void SpawnReward()
    {
        GameObject reward = Instantiate(rewards[Random.Range(0, rewards.Count)]) as GameObject;
        reward.transform.position = Random.insideUnitCircle * 10;

        while (Vector2.Distance(reward.transform.position, Vector2.zero) < 6.0f)
            reward.transform.position = Random.insideUnitCircle * 10;
    }



}
