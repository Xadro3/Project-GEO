using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video_Controller : MonoBehaviour
{
    public string vidname;
    VideoPlayer vidplayer;


    // Start is called before the first frame update
    void Start()
    {
        vidplayer = GetComponent<VideoPlayer>();
        vidplayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, vidname);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Play();
        }

    }
    void Play()
    {
        vidplayer.Play();
        vidplayer.isLooping = true;
    }
}
