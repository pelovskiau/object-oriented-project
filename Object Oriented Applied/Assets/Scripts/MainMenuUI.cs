using UnityEngine;
using TMPro;
using System.IO;
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
    void PlayClicked()
    {
        MainPanel.SetActive(false);
        DifficultyPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
