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

    public void TextBoxInput(string input)
    {
        inputText = input;
        DisplayReactionToInput();
    }

    private void DisplayReactionToInput()
    {
        reactionTextBox.text = "Input: " + inputText;
        reactionGroup.SetActive(true);
    }
}
