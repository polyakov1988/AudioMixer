using UnityEngine;
using UnityEngine.Audio;

public class AudioMixer : MonoBehaviour
{
    private readonly float _minVolume = -80;
    private readonly float _maxVolume = 0;
    
    private readonly string _masterVolume = "MasterVolume";
    private readonly string _musicVolume = "MusicVolume";
    private readonly string _effectsVolume = "EffectsVolume";
    
    [SerializeField] private AudioMixerGroup _master;
    [SerializeField] private AudioMixerGroup _music;
    [SerializeField] private AudioMixerGroup _effects;

    public void ToggleMusic(bool isEnable)
    {
        if (isEnable)
        {
            _master.audioMixer.SetFloat(_masterVolume, _maxVolume);
        }
        else
        {
            _master.audioMixer.SetFloat(_masterVolume, _minVolume);
        }
    }

    public void ChangeMasterVolume(float volume)
    {
        _master.audioMixer.SetFloat(_masterVolume, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }
    
    public void ChangeMusicVolume(float volume)
    {
        _music.audioMixer.SetFloat(_musicVolume, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }
    
    public void ChangeEffectsVolume(float volume)
    {
        _effects.audioMixer.SetFloat(_effectsVolume, Mathf.Lerp(_minVolume, _maxVolume, volume));
    }
}
