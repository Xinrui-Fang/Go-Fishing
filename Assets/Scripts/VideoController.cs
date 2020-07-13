using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    // Start is called before the first frame update
    //设置VideoPlayer、RawImage和当前播放视频索引参数
    private VideoPlayer videoPlayer;
    private RawImage rawImage;
    //private int currentClipIndex;

    //设置相关文本和按钮参数以及视频列表
    public Text text_PlayOrPause;
    public Button button_PlayOrPause;
    public VideoClip[] videoClips;

    void Start()
    {
        //获取VideoPlayer和RawImage组件，以及初始化当前视频索引
        videoPlayer = this.GetComponent<VideoPlayer>();
        rawImage = this.GetComponent<RawImage>();
        //currentClipIndex = 1;
        
        //设置相关按钮监听事件
        button_PlayOrPause.onClick.AddListener(OnPlayOrPauseVideo);

    }

    // Update is called once per frame
    void Update()
    {
        //没有视频则返回，不播放
        if (videoPlayer.texture == null)
        {
            return;
        }
        //渲染视频到UGUI上
        //Debug.Log(ButtonPlay.currentClipIndex);
        videoPlayer.clip = videoClips[ButtonPlay.currentClipIndex];
        rawImage.texture = videoPlayer.texture;

    }

    private void OnPlayOrPauseVideo()
    {
        
        
         if (videoPlayer.isPlaying == true)
        {
            videoPlayer.Pause();
            text_PlayOrPause.text = "播放";
        }
        else
        {
            videoPlayer.Play();
            text_PlayOrPause.text = "暂停";
        }
         

    }

}
