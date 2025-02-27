﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float dogSpawnCooldown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        dogSpawnCooldown -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (dogSpawnCooldown <= 0))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogSpawnCooldown = 1.0f;
        }
    }
}
