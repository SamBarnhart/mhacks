using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OpenAI;
public class input : MonoBehaviour
{
    public static string inputtxt;
    public static string outfacingtxt ="";
    private OpenAIApi openai = new OpenAIApi();
    private string prompt = "Assume the role of an expert fantasy novelist that specializes in interactive fiction, and the characters, groups, and organizations, stories, events, and magical artefacts. The adventure takes in the world of the Medival Age. Provide suitable names for characters, locations, groups, and organizations, events, and magical artefacts and objects. Give a narrative description of everything that follows, while remaining consistent with the era the story is taking place in, without scripting, generating, describing, or controlling my actions, thoughts, emotions, feelings, spoken and unspoken words, and dialogue in the story, scenes, events, descriptions, and converstaions that follow. Limit your responses to 100 words or fewer. Have characters always use dialogue when interacting with me. Always conduct all conversations and dialogues in quotation marks in the style of a novel. I arrive in a city on the Black Coast. What is the city's name and what do I see as I arrive?";
    private List<ChatMessage> messages = new List<ChatMessage>();

    // Start is called before the first frame update

    private async void SendReply()
     {
        Debug.Log("Test 1");
        var newMessage = new ChatMessage()
        {
            Role = "user",
            Content = inputtxt
        };
        Debug.Log(messages.Count);
        if (messages.Count == 0) newMessage.Content = prompt + "\n" + inputtxt;
        messages.Add(newMessage);
        Debug.Log("test 2");
        var completionResponse = await openai.CreateChatCompletion(new CreateChatCompletionRequest()
        {
            Model = "gpt-3.5-turbo-0613",
            Messages = messages
     });
        
        if (completionResponse.Choices != null & completionResponse.Choices.Count > 0) {
            Debug.Log(completionResponse.Choices[0].Message.Content);
            var message = completionResponse.Choices[0].Message;
            //message.Content = message.Content.Trim();

            messages.Add(message);
            Debug.Log(message.Content);
            outfacingtxt = message.Content;
            Debug.Log("test 3");
        } else {
            Debug.LogWarning("No text was generated from this prompt.");
        }
     }

    public void ReadStringInput(string s){
        SendReply();
        //if (messages.Count == 0) {} else {inputtxt=messages[messages.Count-1].Content;}
        
        Debug.Log(outfacingtxt);

    }

}
