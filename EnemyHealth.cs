using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {


    public float Health = 25f;

    public void TakeDamage(float amnt)
    {
        Health -= amnt;
        if (Health <= 0)
        {
            print("Enemy Has died!!!");
        }

        print("Enemy took some damage");
    }

}
