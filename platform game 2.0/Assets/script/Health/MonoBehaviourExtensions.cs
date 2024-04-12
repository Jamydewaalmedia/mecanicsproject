using UnityEngine;
using System.Collections;

public static class MonoBehaviourExtensions
{
    public static void DelayedAction(this MonoBehaviour monoBehaviour, float delayTime, System.Action action)
    {
        monoBehaviour.StartCoroutine(DelayCoroutine(delayTime, action));
    }

    private static IEnumerator DelayCoroutine(float delayTime, System.Action action)
    {
        yield return new WaitForSeconds(delayTime);
        action?.Invoke();
    }
    public static void WriteToConsole(this MonoBehaviour monoBehaviour, string message, Color textColor, bool bold = false,
        bool italic = false, bool includeTimestamp = false)
    {
        string formattedMessage = message;

        
        if (bold)
            formattedMessage = "<b>" + formattedMessage + "</b>";
        if (italic)
            formattedMessage = "<i>" + formattedMessage + "</i>";

        // Construct rich text color tag
        string colorTag = ColorUtility.ToHtmlStringRGB(textColor);
        formattedMessage = "<color=#" + colorTag + ">" + formattedMessage + "</color>";

       
        if (includeTimestamp)
            formattedMessage = $"[{Time.time:F2}] {formattedMessage}";

        // Print the message
        Debug.LogFormat("{0}", formattedMessage);
        
    }
}

