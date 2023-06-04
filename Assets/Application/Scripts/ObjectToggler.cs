using System.Collections.Generic;
using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects;

    private int activeObjectIndex = 0;

    private float lastTime = Time.time;

    private void Start()
    {
        SetNextObjectActive();
    }

    // Update is called once per frame
    void Update()
    {
        if( lastTime + 5 < Time.time)
        {
            lastTime = Time.time;
            activeObjectIndex++;
            if (activeObjectIndex >= gameObjects.Count)
            {
                activeObjectIndex = 0;
            }
            SetNextObjectActive();
        }
    }

    private void SetNextObjectActive()
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(false);
        }
        gameObjects[activeObjectIndex].SetActive(true);
    }
}
