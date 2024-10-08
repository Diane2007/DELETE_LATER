using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaiterScript : MonoBehaviour
{
    //Define the greetings array and menu list
    string[] greetingsArray;
    List<string> menuList;

    public TextMeshProUGUI menuText, waiterText;

    //lines for ordering
    string line0, line1, line2, line3, line4, line5;

    int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //initialize menu list as an empty list of string
        menuList = new List<string>();

        AddFoodItems("Benedict Egg", "Sausage Egg and Cheese Sandwich", "Two Eggs and Style",
            "Creamy Oatmeal with Nuts and Fruits", "House Fries");

        Debug.Log("This is our menu: " + menuList[0] + ", " + menuList[1] + ", " + menuList[2] + ", "
            + menuList[3] + ", " + menuList[4]);

        menuText.text = "This is our menu: " + menuList[0] + ", " + menuList[1] + ", " + menuList[2] + ", "
            + menuList[3] + ", " + menuList[4];

        //initialize the lines form the waiter
        line0 = "Welcome!";
        line1 = "Here is our menu!";
        line2 = "Are you allergic to anything?";
        line3 = "Let me know if you are ready to order!";
        line4 = "What can I get for you?";
        line5 = "Your food will be with you shortly.";

        greetingsArray = new string[] {line0, line1, line2, line3, line4, line5};

        //show line 0 on program start
        waiterText.text = greetingsArray[currentIndex];
    }

    void AddFoodItems(string food0, string food1, string food2, string food3, string food4)
    {
        menuList.Add(food0);
        menuList.Add(food1);
        menuList.Add(food2);
        menuList.Add(food3);
        menuList.Add(food4);
    }

    public void ClickContinueButton()
    {
        //length: 6
        if (currentIndex < greetingsArray.Length - 1)
        {
            currentIndex++;
            waiterText.text = greetingsArray[currentIndex];
        }
        else
        {
            Debug.Log("The end of the conversation!");
        }
    }

}
