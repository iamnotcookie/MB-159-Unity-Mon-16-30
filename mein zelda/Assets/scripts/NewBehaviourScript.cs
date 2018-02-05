using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	int a = 50;
	int b = 23;
	int c;
	int d = 45;

	int Sum(int _arg1, int _arg2, int _arg3)
	{
		return ( _arg2 + _arg1 + _arg3);
	}

	int Diff(int _arg1, int _arg2, int _arg3)
	{
		return ( _arg2 - _arg1 -  _arg3);
	}

	int Mult(int _arg1, int _arg2, int _arg3)
	{
		return ( _arg2 * _arg1 * _arg3);
	}
	int Div(int _arg1, int _arg2, int _arg3)
	{
		return ( _arg2 / _arg1 / _arg3);
	}
//	string mommy;
//	string daddy;
//	string granny;

	//string word;
	//string anotherword;

//	int momsAge;
//	int dadsAge;
//	int grandmothersAge;
//	int age;

//	int Sum(int _arg1 = 0, int _arg2 = 0)
//	{
//		return (_arg1 + _arg2);
//	}

	// Use this for initialization
	void Start ()
	{
		Debug.Log (Sum(69, 69, 69));
		Debug.Log (Diff(69, 69, 69));
		Debug.Log (Mult(69, 69, 69));
		Debug.Log (Div(69, 69, 69));



		Sum (a,d,b);
		Debug.Log (a);
		Debug.Log (b);
		Debug.Log (c);
		Debug.Log (a + ", " + b + ", " + c);
		Debug.Log (a + b + c);
		Debug.Log (Sum (a,b,d));
		c = Sum (b,c,a);
		Debug.Log (c);
		c = Sum (a, b, c);
		Debug.Log (c);
		//word = "Hello,";
		//anotherword = "world!";

	//	mommy = "Galina";
	//	daddy = "Alex";
	//	granny = "Sonya";
	//	momsAge = 40;
	//	dadsAge = 43;
	//	grandmothersAge = 69;

		//a = 1;
		//Debug.Log (word + " " + anotherword + "I am " + age.ToString() + " years old!");
	//	Debug.Log (mommy + "'s age is " + momsAge);
	//	Debug.Log (daddy + "'s age is " + dadsAge);
	//	Debug.Log (granny + "'s age is" + grandmothersAge);
	//	Debug.Log ("Difference between mommy and daddys ages " + (dadsAge - momsAge));
	//	Debug.Log ("Summary age of family " +  (grandmothersAge + dadsAge + momsAge));
//		Debug.Log(Sum(4,5))
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}