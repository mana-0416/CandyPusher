using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource AudioSource;
    static public AudioManager instance;

    // Awake -> シーン開始時に実行。初回１度にしか呼ばれない特徴を生かして初期化につかう
    void Awake()
    {
        // null -> 無効な値を表す
        if (instance == null)
        {
            instance = this;

        }else
        
            Destroy(this.gameObject);
        }

    public void PlaySE()
    {
        AudioSource.clip = audioClips[1];
        AudioSource.Play();
    }

    public AudioClip[] bgmAudioClips;
    public AudioSource bgmAudioSource;
    public void PlayBGM()
    {
        bgmAudioSource.clip = bgmAudioClips[0];
        bgmAudioSource.Play();
    }
    void Start()
    {
        // AddComponent<作りたいComponent名>();
        // ↑これでコード上からComponentを追加できる
        AudioSource = this.gameObject.AddComponent<AudioSource>();
        bgmAudioSource = this.gameObject.AddComponent<AudioSource>();
        bgmAudioSource.loop = true;

        PlayBGM();
    }
 

}