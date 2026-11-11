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
    [SerializeField] private AudioClip teleport;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void playGreenBallSound()
    {
        sfxSource.PlayOneShot(greenBallSound);
    }
    public void playRedBallSound()
    {
        sfxSource.PlayOneShot(redBallSound);
    }
    public void playJumpSound()
    {
        sfxSource.PlayOneShot(jumpSound);
    }

    public void playTeleport()
    {
        sfxSource.PlayOneShot(teleport);
    }
    void Update()
    {
        
    }
}
