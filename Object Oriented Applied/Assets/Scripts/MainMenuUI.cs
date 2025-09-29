using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Play()
    {
        MainPanel.SetActive(false);//we swap it out to the difficulty options, fairly self explanatory.
        DifficultyPanel.SetActive(true);
    }
    public void Difficuly(int difficulty)
    { 
        //based on 1-3 it'll set the time difficulty, may want this to pull in data manager as well
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
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode(); //QUIT
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
