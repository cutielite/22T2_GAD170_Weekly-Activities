using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HannahCruz
{
    /// <summary>
    /// Week 8 Activities regarding Enums
    /// </summary>
    public class WeekEight : MonoBehaviour
    {
        /// <summary>
        /// Mr. Fruit would be proud.
        /// </summary>
        public enum Fruit
        {
            /// <summary>
            /// High tier fruit.
            /// </summary>
            Lychee, 
            /// <summary>
            /// Fun Fact: Mango is the national fruit of the Philippines.
            /// </summary>
            Mango, 
            /// <summary>
            /// Stinky.
            /// </summary>
            Durian, 
            /// <summary>
            /// OKay, but I wouldn't eat them all the time
            /// </summary>
            Rambutan, 
            /// <summary>
            /// Why did they name this fruit after a language?
            /// </summary>
            Mandarin
        }

        public Fruit favouriteFruit;

        public Fruit[] myFruitsBasket = new Fruit[8];


        

        public enum AIState
        {
            Underfined, Idle, Attacking, Chasing, Fleeing, Dancing, Dying
        }

        private void Start()
        {
            favouriteFruit = Fruit.Lychee;

            Debug.Log("My Favourite fruit is: " + favouriteFruit);

            for (int i = 0; i < myFruitsBasket.Length; i++)
            {
                //myFruitsBasket[i] = Fruit.Mango;
                //Debug.Log("In my fruits basket there is a " + myFruitsBasket [i]);

                CheckFruit(myFruitsBasket [i]);
            }
        }

        private void CheckFruit(Fruit typeOfFruit)
        {
            //We want to output different text depending on which fruit was chosen.
            //If it is an apple, do X, if it is an orange, do Y etc.

            switch (typeOfFruit)
            {
                case Fruit.Lychee:
                    {
                        // What the output will be if Lychee gets picked
                        Debug.Log("Lychee...The most superior fruit.");
                    }
                    break;
                case Fruit.Mango:
                    break;
                case Fruit.Durian:
                    break;
                case Fruit.Rambutan:
                    break;
                case Fruit.Mandarin:
                    break;
                default:
                    break;
            }
        }

    }
}
