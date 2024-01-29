using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2 : MonoBehaviour
{
	//declaring needed variables
	float coverPrice;
	int bookAmount;
	float discountPercentage;
	float shippingInitial;
	float shippingAdditional;
	float wholesaleCost;
	float wholesaleProfit;

	float WholesaleCostCalculator(float coverPrice, float discountPercentage, int bookAmount)
	{
		float discountedPrice = coverPrice * (discountPercentage);
		//Debug.Log("discounted price: $" + discountedPrice);
		float wholesaleCost = (discountPercentage * bookAmount) + shippingInitial + (shippingAdditional * bookAmount);
		return(wholesaleCost);
	}
	
	float ProfitCalculator(float wholesaleCost, int bookAmount, float coverPrice)
	{
		float wholesaleProfit = ((bookAmount * coverPrice) - wholesaleCost);
		return(wholesaleProfit);
	}

    void Start()
    {
        //update variables with whatever values you would like
		coverPrice = 15f; //the X value
		bookAmount = 1000; // the Y value
		discountPercentage = .6f; //40% discount
		shippingInitial = 3f;
		shippingAdditional = .75f;
		
		wholesaleCost = WholesaleCostCalculator(coverPrice, discountPercentage, bookAmount); //calculating the cost
		wholesaleProfit = ProfitCalculator(wholesaleCost, bookAmount, coverPrice);//calculating the profit
		
		Debug.LogFormat("The wholesale cost is: ${0} and the wholesale profit is: ${1}", wholesaleCost, wholesaleProfit);
    }
}
