using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;

    void Start()
    {
        if (DataManager.Instance != null)
        {
            musicSource.volume = DataManager.Instance.VolumeSetting;
        }
    }
}
