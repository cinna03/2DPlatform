using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {
	public GameObject HelpPanel;
	public GameObject SettingsPanel;
	public GameObject MainMenuPanel;

	public void PlayGame() {
		SceneManager.LoadScene ("GameScene-ALU");
	}

    private void Start()
    {
		ShowMainMenu();
    }

	public void ShowMainMenu()
	{
		MainMenuPanel.SetActive(true);
        HelpPanel.SetActive(false);
        SettingsPanel.SetActive(false);
    }

	public void ShowHelp()
	{
        MainMenuPanel.SetActive(false);
        HelpPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }

	public void ShowSettings()
	{
        MainMenuPanel.SetActive(false);
        HelpPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }


}
