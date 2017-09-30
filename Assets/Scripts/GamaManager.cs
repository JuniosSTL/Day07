using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamaManager : MonoBehaviour
{
    public string nextStage;
    public bool isComplete = false;

	void Update ()
    {
		if ( GameObject.FindGameObjectsWithTag("Coin").Length == 0)
        {
            if (isComplete == false)
            {
                isComplete = true;
                Debug.Log("Stage Clear");
                //2초 뒤에 다음 스테이지 이동
                Invoke("OpenNextStage", 2.0f);
            }
        }
	}

    void OpenNextStage()
    {
        SceneManager.LoadScene(nextStage);
    }
}
