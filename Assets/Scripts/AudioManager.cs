using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip greenBallSound;
    [SerializeField] private AudioClip redBallSound;
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip backgroundMusic;

private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
        print("music played");
    }

    public void playGreenBallSound()
    {
        print("green ball sound played");
        sfxSource.PlayOneShot(greenBallSound);
    }
    public void playRedBallSound()
    {
        print("red ball sound played");
        sfxSource.PlayOneShot(redBallSound);
    }
    public void playJumpSound()
    {
        print("jump sound played");
        sfxSource.PlayOneShot(jumpSound);
    }
    void Update()
    {
        
    }
}
