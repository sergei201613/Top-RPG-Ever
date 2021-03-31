using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUtility
{
    public static System.Action Delay(System.Action action, float delayInSeconds, MonoBehaviour mono)
    {
        IEnumerator Del()
        {
            yield return new WaitForSeconds(delayInSeconds);
            action?.Invoke();
        }

        mono.StartCoroutine(Del());
        return action;
    }

    public static System.Action Delay(float delayInSeconds, MonoBehaviour mono, System.Action action)
    {
        IEnumerator Del()
        {
            yield return new WaitForSeconds(delayInSeconds);
            action?.Invoke();
        }

        mono.StartCoroutine(Del());
        return action;
    }
}
