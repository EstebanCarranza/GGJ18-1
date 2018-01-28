using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {
	public Astronauta astronauta;
	public static play ins;
	void Awake() {
		ins = this;
	}
	public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

	public void exitGame()
	{
		Application.Quit();
	}
		
	public void OnPointerEnter (PointerEventData eventData)
	{
		//canvasScript.ins.spawnAstronauta ();
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		//canvasScript.ins.dessapearAstronauta ();

	}
}