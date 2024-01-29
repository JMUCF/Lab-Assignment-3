using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{
	//declaring needed variables
	string courseName;
	float moduleAmount;
	float readingAmount;
	float quizAmount;
	float assignmentAmount;
	bool taughtBefore;
	float score;
	
	float ScoreCalculator(float moduleAmount, float readingAmount, float quizAmount, float assignmentAmount, bool taughtBefore)
	{
		float score = (moduleAmount * .15f) + (readingAmount * .3f) + (quizAmount * .15f) + (assignmentAmount * .3f); //multiply each value to get their percentage
		//Debug.Log(score);
		if(taughtBefore == false) // difficulty increased by 10% if professor has not taught the class before
			score += 1.0f;
		//Debug.Log(score);
		if(score > 10) //capping the score at 10 in case values make it exceed
			score = 10;
		return(score);
	}
	
    void Start()
    {
		//update variables with whatever values you would like
		courseName = "Calculus";
		moduleAmount = 10f;
		readingAmount = 5f;
		quizAmount = 3f;
		assignmentAmount = 10f;
		taughtBefore = true;
		
        score = ScoreCalculator(moduleAmount, readingAmount, quizAmount, assignmentAmount, taughtBefore); 
		Debug.LogFormat("The challenge score for {0} is: {1}", courseName, score);
    }
}
