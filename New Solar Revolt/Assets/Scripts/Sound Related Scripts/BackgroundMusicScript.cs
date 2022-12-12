using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{
    public static BackgroundMusicScript bgMusicInstance;

    private void Awake()
    {
        if (bgMusicInstance != null && bgMusicInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        bgMusicInstance = this;
        DontDestroyOnLoad(this);
    }
}
