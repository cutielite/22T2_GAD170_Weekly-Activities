using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HannahCruz
{
    public class WeekEightActivity : MonoBehaviour
    {

       private void Start()
        {

            for (int i = 1; i <101; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Debug.Log("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Debug.Log("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Debug.Log("Buzz");
                }

                else
                {
                    Debug.Log(i);
                }
            }
        }




    }
}
