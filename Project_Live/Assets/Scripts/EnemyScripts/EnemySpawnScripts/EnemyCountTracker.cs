using System.Collections;
using System.Collections.Generic;
using UnityEditor.Scripting;
using UnityEngine;

public class EnemyCountTracker
{
    EnemyType enemyType;
    int prev_Count;

    public EnemyCountTracker(EnemyType enemyType)
    {
        this.enemyType = enemyType;
        prev_Count = -1;
    }

    public bool HasChanged(out int currentCount) //敵の数が変わったどうか判定する
    {
        currentCount = EnemyRegistry.GetCount(enemyType);

        //Debug.Log(enemyType + ":" + currentCount);

        if (currentCount != prev_Count)
        {
            //Debug.Log(enemyType + "の数が変化した");
            prev_Count = currentCount;
            return true;
        }

        return false;
    }
}
