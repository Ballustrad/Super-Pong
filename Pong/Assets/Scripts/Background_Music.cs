using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Music : MonoBehaviour
{
    private static Background_Music backgroundMusic;
        private void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
