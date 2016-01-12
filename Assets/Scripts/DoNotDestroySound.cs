using UnityEngine;
using System.Collections;

public class DoNotDestroySound : MonoBehaviour
{
    void ContinueSound()
    {
        DontDestroyOnLoad(gameObject);
        if (GameObject.FindGameObjectsWithTag(gameObject.tag).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
