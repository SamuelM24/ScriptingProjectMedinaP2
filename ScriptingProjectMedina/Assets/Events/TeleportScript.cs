using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    void OnEnablle()
    {
        EventManager.OnClicked += Teleport;
    }

    void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(-3f, 1.0f);
        transform.position = pos;
    }
}