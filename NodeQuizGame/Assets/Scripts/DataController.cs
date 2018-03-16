using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class DataController : MonoBehaviour {

    public RoundData[] allRoundData;
    public string gameDataFilePath = "/StreamingAssets/data.json";

    // Use this for initialization
    void Start () {

        DontDestroyOnLoad(gameObject);
        LoadGameData();
        SceneManager.LoadScene("MenuScreen");
	}
	
	// Update is called once per frame
	public RoundData GetCurrentRoundData () {

        return allRoundData[0];
		
	}

    private void LoadGameData()
    {
        string filePath = Application.dataPath + gameDataFilePath;

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);

            QandAData loadedData = JsonUtility.FromJson<QandAData>(dataAsJson);

            allRoundData = loadedData.questionsAndAnswers;
        }
        else
        {
            Debug.Log("Rip in Peps.");
        }
    }
}
