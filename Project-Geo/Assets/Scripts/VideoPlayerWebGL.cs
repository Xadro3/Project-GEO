using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

//public class VideoPlayerWebGL : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//        string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "Main Menu 3.mp4");
//        player.url = filePath;

//        player.renderMode = VideoRenderMode.CameraNearPlane;
//        player.targetCameraAlpha = 1.0f;
//        player.Play();
//    }

//}
namespace MainMenuVid
{
    [RequireComponent(typeof(VideoPlayer))]
    public class VideoPlayerWebGL : MonoBehaviour
    {
        [SerializeField]
        private string _movieFilename;

        private void Start()
        {
            StartCoroutine(PlayMovie(_movieFilename));
        }

        /// <summary>
        /// Stream the specified video.
        /// </summary>
        /// <param name="filename">The video file.</param>
        /// <returns>Coroutine.</returns>
        private IEnumerator PlayMovie(string filename)
        {
            VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
            if (videoPlayer)
            {
                // It's important that the video is in /Assets/StreamingAssets
                string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, _movieFilename);

                Debug.Log($"About play video: {_movieFilename}");

                videoPlayer.url = videoPath;

                videoPlayer.Play();
                while (videoPlayer.isPlaying)
                {
                    yield return null;
                }

                videoPlayer.Stop();
            }
        }
    }
}