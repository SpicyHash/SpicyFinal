using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData:RoundData{

    
}

[System.Serializable]
public class QandAData
{
    [Header("Questions and Answers")]
    public GameData[] questionsAndAnswers;
}


