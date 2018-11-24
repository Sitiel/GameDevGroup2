using UnityEngine;
using System.Collections;

public class LumberjackHut : Building
{
    public float woodCreationTimer = 5f;
    float currentTimer;
    GameResources resources;

    public override void Start()
    {
        currentTimer = woodCreationTimer;
        resources = FindObjectOfType<GameResources>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isBuild){
            currentTimer -= Time.deltaTime;
            if(currentTimer <= 0){
                currentTimer = woodCreationTimer;
                resources.updateWood(1);
            }
        }
    }
}
