using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuUI : MonoBehaviour
{   
    //Temporary, gathering the menu UI with a few options present.
    [Header("Main Menu Buttons")]
    [SerializeField] private Button PlayButton;
    [SerializeField] private Button OptionsButton;
    [SerializeField] private Button CreditsButton;
    [SerializeField] private Button ExitButton;
    [Header("Back Buttons")]
    [SerializeField] private Button OptionsBackButton;
    [SerializeField] private Button DifficultyBackButton;
    [Header("Difficulty Buttons")]
    [SerializeField] private Button Easy;
    [SerializeField] private Button Medium;
    [SerializeField] private Button Hard;
    [Header("Input & Display")]
    [SerializeField] private Button SaveButton;
    [SerializeField] private TMP_InputField Name;
    [SerializeField] private Slider VolumeSlider;
    [SerializeField] private TMP_Text PlayerName;
    [Header("Panels")]
    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject OptionsPanel;
    [SerializeField] private GameObject DifficultyPanel;
    [SerializeField] private AudioSource AudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void Awake()
    {
        //grab the audio setting
        AudioSource=gameObject.GetComponent<AudioSource>();
        AudioSource.volume= DataManager.Instance.VolumeSetting;
        VolumeSlider.value= DataManager.Instance.VolumeSetting;
        PlayerName.text=DataManager.Instance.PlayerName;
    }
    public void UpdateName()
    { 
        DataManager.Instance.SetName(Name.text);
        PlayerName.text=DataManager.Instance.PlayerName;
    }
    public void Play()
    {
        MainPanel.SetActive(false);//we swap it out to the difficulty options, fairly self explanatory.
        DifficultyPanel.SetActive(true);
    }
    public void Difficuly(int difficulty)
    {
        switch (difficulty)
        {
            case (1):
                DataManager.Instance.GameDifficulty = difficulty;
                SceneManager.LoadScene(1);
                break;
            case(2):
                DataManager.Instance.GameDifficulty = difficulty;
                SceneManager.LoadScene(1);
                break;
            case(3):
                DataManager.Instance.GameDifficulty = difficulty;
                SceneManager.LoadScene(1);
                break;


        }
        //based on 1-3 it'll set the time difficulty, may want this to pull in data manager as well
    }
    public void RollCredits()
    {
        SceneManager.LoadScene(2);
    }
    public void Options()
    {
        MainPanel.SetActive(false);//swaps it out to options
        OptionsPanel.SetActive(true);
    }
    public void Back()
    { 
        OptionsPanel.SetActive(false);
        DifficultyPanel.SetActive(false );
        MainPanel.SetActive(true );//lazy, no matter what we go back to title on back. because it'll only ever go there.
    }
    public void SetVolume() 
    {
        DataManager.Instance.VolumeSetting=VolumeSlider.value;
        AudioSource.volume = VolumeSlider.value;
        Debug.Log("Volume set to "+VolumeSlider.value);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode(); //QUIT
#else
        Application.Quit();
#endif
    }
    public void SaveButtonClicked()
    {
        DataManager.Instance.Save(); //Saves when the button is clicked.
        Debug.Log("Saved");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator ApplyVolumeNextFrame()
    {
       yield return null; // wait 1 frame
       AudioSource.volume = DataManager.Instance.VolumeSetting;
    }
}
