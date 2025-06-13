using System.Collections.Generic;
using UnityEngine;

public class BadWordFilter : MonoBehaviour
{
    private List<string> badWords = new List<string> { "дурак" }; // или список json

    public string FilterText(string input)
    {
        foreach (var word in badWords)
        {
            input = input.Replace(word, "#");
        }
        return input;
    }

    void Start()
    {
        string text = "пример плохих слов, дурак"; // отображение как "пример плохих слов, ####"
        string filteredText = FilterText(text);
        Debug.Log(filteredText);
    }
}
