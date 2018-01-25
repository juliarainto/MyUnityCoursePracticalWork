using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

    public Text GoalText;
    public string FinalText;

    void Start()
    {
        GoalText.text = "";
    }

    void OnCollisionEnter(Collision col)
    {
        GoalText.text = FinalText;
    }
}
