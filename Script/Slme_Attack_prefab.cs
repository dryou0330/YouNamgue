using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slme_Attack_prefab : MonoBehaviour
{
    [SerializeField]
    private GameObject slim_monster_script;

    [SerializeField]
    private GameObject slim_position;

    [SerializeField]
    private float round_Speed;

    void Start()
    {
        
    }


    void Update()
    {
        Rotation();
    }

    public void Rotation()
    {
        transform.RotateAround(slim_position.transform.position, Vector3.down, round_Speed);
    }
}
