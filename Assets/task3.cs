using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{
	//declaring needed variable
	int paymentAmount; //X

	void BillCalculator(int paymentAmount)
	{
		/*
			declares a variable for each bill in descending order
			sets the variable equal to the total amount divided by the value of the bill to see how many there are
			then modulus the total amount by the value of the bill so that it is ready for the calculation of the next lower bill
		*/
		int hundreds = paymentAmount / 100;  
		paymentAmount%=100;
		
		int fifties = paymentAmount / 50;
		paymentAmount%=50;
		
		int twenties = paymentAmount / 20;
		paymentAmount%=20;
		
		int tens = paymentAmount / 10;
		paymentAmount%=10;
		
		int fives = paymentAmount / 5;
		paymentAmount%=5;
		
		int ones = paymentAmount;
		
		Debug.LogFormat("You will get: {0} hundreds, {1} fifties, {2} twenties, {3} tens, {4} fives, {5} ones", hundreds, fifties, twenties, tens, fives, ones);
		
	}
    void Start()
    {
        paymentAmount = 1567; //this is X, set it to whatever input you would like
		BillCalculator(paymentAmount);
    }
}
