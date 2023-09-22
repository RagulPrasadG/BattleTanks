using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] GameObject tankPrefab;
    private void Start()
    {
        if(tankPrefab)
        Instantiate(tankPrefab, this.transform.position, Quaternion.identity);
    }
}
