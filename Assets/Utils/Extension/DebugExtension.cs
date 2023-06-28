using System;

public static class Debug
{
    const string MSG_TRUE = "Value is True";
    const string MSG_FALSE = "Value is False";
    const string MSG_NULL = "Value is Null";
    const string MSG_NOT_NULL = "Value is Not Null";

    public static void Log(object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.Log(message);
#endif
    }

    public static void Log(object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.Log(message, context);
#endif
    }

    public static void LogIfTrue(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.Log(MSG_TRUE);
#endif
    }

    public static void LogIfTrue(bool condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.Log(message);
#endif
    }

    public static void LogIfTrue(bool condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.Log(message, context);
#endif
    }

    public static void LogIfTrue(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.Log(MSG_TRUE);
#endif
    }

    public static void LogIfTrue(Func<bool> condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.Log(message);
#endif
    }

    public static void LogIfTrue(Func<bool> condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.Log(message, context);
#endif
    }

    public static void LogIfFalse(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.Log(MSG_FALSE);
#endif
    }

    public static void LogIfFalse(bool condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.Log(message);
#endif
    }

    public static void LogIfFalse(bool condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.Log(message, context);
#endif
    }

    public static void LogIfFalse(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.Log(MSG_FALSE);
#endif
    }

    public static void LogIfFalse(Func<bool> condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.Log(message);
#endif
    }

    public static void LogIfFalse(Func<bool> condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.Log(message, context);
#endif
    }

    public static void LogIfNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.Log(MSG_NULL);
#endif
    }

    public static void LogIfNull<T>(T value, object message) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.Log(message);
#endif
    }

    public static void LogIfNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.Log(MSG_NULL, context);
#endif
    }

    public static void LogIfNull<T>(T value, object message, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value == null) UnityEngine.Debug.Log(message, context);
#endif
    }

    public static void LogIfNotNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.Log(MSG_NOT_NULL);
#endif
    }

    public static void LogIfNotNull<T>(T value, object message) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.Log(message);
#endif
    }

    public static void LogIfNotNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.Log(MSG_NOT_NULL, context);
#endif
    }

    public static void LogIfNotNull<T>(T value, object message, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.Log(message, context);
#endif
    }

    public static void LogWarning(object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.LogWarning(message);
#endif
    }

    public static void LogWarning(object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.LogWarning(message, context);
#endif
    }

    public static void LogWarningIfTrue(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogWarning(MSG_TRUE);
#endif
    }

    public static void LogWarningIfTrue(bool condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogWarning(message);
#endif
    }

    public static void LogWarningIfTrue(bool condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogWarning(message, context);
#endif
    }

    public static void LogWarningIfTrue(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogWarning(MSG_TRUE);
#endif
    }

    public static void LogWarningIfTrue(Func<bool> condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogWarning(message);
#endif
    }

    public static void LogWarningIfTrue(Func<bool> condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogWarning(message, context);
#endif
    }

    public static void LogWarningIfFalse(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogWarning(MSG_FALSE);
#endif
    }

    public static void LogWarningIfFalse(bool condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogWarning(message);
#endif
    }

    public static void LogWarningIfFalse(bool condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogWarning(message, context);
#endif
    }

    public static void LogWarningIfFalse(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogWarning(MSG_FALSE);
#endif
    }

    public static void LogWarningIfFalse(Func<bool> condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogWarning(message);
#endif
    }

    public static void LogWarningIfFalse(Func<bool> condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogWarning(message, context);
#endif
    }

    public static void LogWarningIfNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogWarning(MSG_NULL);
#endif
    }

    public static void LogWarningIfNull<T>(T value, object message) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogWarning(message);
#endif
    }

    public static void LogWarningIfNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogWarning(MSG_NULL, context);
#endif
    }

    public static void LogWarningIfNull<T>(T value, object message, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogWarning(message, context);
#endif
    }

    public static void LogWarningIfNotNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogWarning(MSG_NOT_NULL);
#endif
    }

    public static void LogWarningIfNotNull<T>(T value, object message) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogWarning(message);
#endif
    }

    public static void LogWarningIfNotNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogWarning(MSG_NOT_NULL);
#endif
    }

    public static void LogWarningIfNotNull<T>(T value, object message, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogWarning(message, context);
#endif
    }

    public static void LogError(object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.LogError(message);
#endif
    }

    public static void LogError(object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.LogError(message, context);
#endif
    }

    public static void LogErrorIfTrue(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogError(MSG_TRUE);
#endif
    }

    public static void LogErrorIfTrue(bool condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogError(message);
#endif
    }

    public static void LogErrorIfTrue(bool condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogError(message, context);
#endif
    }

    public static void LogErrorIfTrue(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogError(MSG_TRUE);
#endif
    }

    public static void LogErrorIfTrue(Func<bool> condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogError(message);
#endif
    }

    public static void LogErrorIfTrue(Func<bool> condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogError(message, context);
#endif
    }

    public static void LogErrorIfFalse(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogError(MSG_FALSE);
#endif
    }

    public static void LogErrorIfFalse(bool condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogError(message);
#endif
    }

    public static void LogErrorIfFalse(bool condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogError(message, context);
#endif
    }

    public static void LogErrorIfFalse(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogError(MSG_FALSE);
#endif
    }

    public static void LogErrorIfFalse(Func<bool> condition, object message)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogError(message);
#endif
    }

    public static void LogErrorIfFalse(Func<bool> condition, object message, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogError(message, context);
#endif
    }

    public static void LogErrorIfNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogError(MSG_NULL);
#endif
    }

    public static void LogErrorIfNull<T>(T value, object message) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogError(message);
#endif
    }

    public static void LogErrorIfNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogError(MSG_NULL, context);
#endif
    }

    public static void LogErrorIfNull<T>(T value, object message, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogError(message, context);
#endif
    }

    public static void LogErrorIfNotNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogError(MSG_NOT_NULL);
#endif
    }

    public static void LogErrorIfNotNull<T>(T value, object message) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogError(message);
#endif
    }

    public static void LogErrorIfNotNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogError(MSG_NOT_NULL, context);
#endif
    }

    public static void LogErrorIfNotNull<T>(T value, object message, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogError(message, context);
#endif
    }

    public static void LogException(Exception exception)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.LogException(exception);
#endif
    }

    public static void LogException(Exception exception, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        UnityEngine.Debug.LogException(exception, context);
#endif
    }

    public static void LogExceptionIfTrue(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogException(new Exception(MSG_TRUE));
#endif
    }

    public static void LogExceptionIfTrue(bool condition, Exception exception)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogException(exception);
#endif
    }

    public static void LogExceptionIfTrue(bool condition, Exception exception, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition) UnityEngine.Debug.LogException(exception, context);
#endif
    }

    public static void LogExceptionIfTrue(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogException(new Exception(MSG_TRUE));
#endif
    }

    public static void LogExceptionIfTrue(Func<bool> condition, Exception exception)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogException(exception);
#endif
    }

    public static void LogExceptionIfTrue(Func<bool> condition, Exception exception, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (condition()) UnityEngine.Debug.LogException(exception, context);
#endif
    }

    public static void LogExceptionIfFalse(bool condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogException(new Exception(MSG_FALSE));
#endif
    }

    public static void LogExceptionIfFalse(bool condition, Exception exception)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogException(exception);
#endif
    }

    public static void LogExceptionIfFalse(bool condition, Exception exception, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition) UnityEngine.Debug.LogException(exception, context);
#endif
    }

    public static void LogExceptionIfFalse(Func<bool> condition)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogException(new Exception(MSG_FALSE));
#endif
    }

    public static void LogExceptionIfFalse(Func<bool> condition, Exception exception)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogException(exception);
#endif
    }

    public static void LogExceptionIfFalse(Func<bool> condition, Exception exception, UnityEngine.Object context)
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!condition()) UnityEngine.Debug.LogException(exception, context);
#endif
    }

    public static void LogExceptionIfNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogException(new NullReferenceException());
#endif
    }

    public static void LogExceptionIfNull<T>(T value, Exception exception) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogException(exception);
#endif
    }

    public static void LogExceptionIfNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogException(new NullReferenceException(), context);
#endif
    }

    public static void LogExceptionIfNull<T>(T value, Exception exception, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (value.Equals(null)) UnityEngine.Debug.LogException(exception, context);
#endif
    }

    public static void LogExceptionIfNotNull<T>(T value) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogException(new Exception(MSG_NOT_NULL));
#endif
    }

    public static void LogExceptionIfNotNull<T>(T value, Exception exception) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogException(exception);
#endif
    }

    public static void LogExceptionIfNotNull<T>(T value, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogException(new Exception(MSG_NOT_NULL), context);
#endif
    }

    public static void LogExceptionIfNotNull<T>(T value, Exception exception, UnityEngine.Object context) where T : class
    {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        if (!value.Equals(null)) UnityEngine.Debug.LogException(exception, context);
#endif
    }
}
