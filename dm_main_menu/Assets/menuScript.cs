using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {
	
	// Public variables
	public Canvas quitMenu;
	public Button newGameButton;
	public Button quitGameButton;


	// Use this for initialization
	void Start () {
		
		// Assign components to each variable
		quitMenu = quitMenu.GetComponent<Canvas> ();
		newGameButton = newGameButton.GetComponent<Button> ();
		quitGameButton = quitGameButton.GetComponent<Button> ();
		
		quitMenu.enabled = false; // disable quit menu at the start
		
	}
	
	public void quitGameButtonPress()
	{
		quitMenu.enabled = true;
		newGameButton.enabled = false;
		quitGameButton.enabled = false;
		
	}
	
	public void NoButtonPress()
	{
		quitMenu.enabled = false;
		newGameButton.enabled = true;
		quitGameButton.enabled = true;
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}
	
	
	public void YesButtonPress()
	{
		QuitGame();
	}
	
	public void newGameButtonPress(string newGameLevel)
	{
		SceneManager.LoadScene(newGameLevel);
	}
	

	
	// Update is called once per frame
	void Update () {
		
	}
}
