using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

public Text time;

private void Update()
{
    time.text = GetTimeString(TimeManager.Instance.GetRemainingTime() + 1);
}

public void Show()
{
    gameObject.SetActive(true);
}

public void Hide()
{
    gameObject.SetActive(false);
}

private string GetTimeString(float timeRemaining)
{
    int minute = Mathf.FloorToInt(timeRemaining / 60);
    int second = Mathf.FloorToInt(timeRemaining % 60);

    return string.Format("{0} : {1}", minute.ToString(), second.ToString());
}
}
