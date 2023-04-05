using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject Square;


    public GameObject[,] squares = new GameObject[9, 9];
    Color32 blackSquaresColor = new Color32(10, 10, 10, 255);// it is important that the white and black squares should not exactly white or black so that the pieces can be seen
    Color32 whiteSquaresColor = new Color32(245, 245, 245, 255);

    bool blackAndWhiteBoardCreationBool = false;

    void CreatBoard()
    {
        for (int i = 1; i < 9; i++)
        {
            blackAndWhiteBoardCreationBool = !blackAndWhiteBoardCreationBool; // for each row this will change start color
            for (int j = 1; j < 9; j++)
            {
                squares[j, i] = Instantiate(Square, new Vector3(j, i), Quaternion.identity);
                if (blackAndWhiteBoardCreationBool)
                {
                    squares[j, i].GetComponent<SpriteRenderer>().material.color = blackSquaresColor;
                    blackAndWhiteBoardCreationBool = false;
                }
                else
                {
                    squares[j, i].GetComponent<SpriteRenderer>().material.color = whiteSquaresColor;
                    blackAndWhiteBoardCreationBool = true;
                }

                //  9,1 9,1 9,2 .... 9,9
                //  8,1
                //  8,1
                //   ...
                //  1,1              
            }
        }
    }

}
