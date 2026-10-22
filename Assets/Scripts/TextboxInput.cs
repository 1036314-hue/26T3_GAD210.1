using TMPro;
using UnityEngine;


public class TextboxInput : MonoBehaviour
{
    
    [SerializeField]
    private string inputText;

    [SerializeField]
    private GameObject reactionGroup;

    [SerializeField]
    private TMP_Text reactionTextBox;

    [SerializeField]
    private TMP_InputField inputField;

    [SerializeField]
    private TextBoxMovement playerMovement;

    
    public void TextBoxInputFunction(string input)
    {
        inputText = input.ToLower();
        playerMovement.inputText = inputText;
        reactionTextBox.text = "Input: " + inputText;
        inputField.text = "";

    }

}
