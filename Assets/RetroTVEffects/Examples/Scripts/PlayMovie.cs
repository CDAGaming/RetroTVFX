using UnityEngine;
using UnityEngine.Video;

public class PlayMovie : MonoBehaviour
{
#if !UNITY_WEBGL
    public VideoPlayer Texture;

    void Start()
    {
        Texture.Play();
    }
#endif
}