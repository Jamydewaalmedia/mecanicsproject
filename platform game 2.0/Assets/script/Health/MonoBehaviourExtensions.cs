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
}

