using PlayFab;
using PlayFab.ClientModels;
using PlayFab.Internal;
using UnityEngine;
using System;

namespace PlayFabAPI
{
    public static class PlayFabUtilities
    {
        const string _debugHeader = "<color=orange>PlayFab Error</color>\n";

        public static void LogError(PlayFabError error, FailureBehavior failBehavior = FailureBehavior.ReturnWhenNull)
        {
            switch (failBehavior)
            {
                case FailureBehavior.DoNothing:
                    break;
                case FailureBehavior.ThrowException:
                    if (error == null)
                        throw new ArgumentException("The error object you provided is null", "error", new NullReferenceException());
                    break;
                case FailureBehavior.DebugError:
                    if (error == null)
                    {
                        Debug.LogError("The error object you provided is null");
                        return;
                    }
                    break;
                case FailureBehavior.ReturnWhenNull:
                    if (error == null)
                        return;
                    break;
                default:
                    throw new NotImplementedException("The provided FailureBehaviour was not implemented.");
            }

            Debug.LogError(_debugHeader + error?.GenerateErrorReport());
        }
    }

    public enum FailureBehavior
    {
        DoNothing = 0,
        ThrowException = 1,
        DebugError = 2,
        ReturnWhenNull = 4
    }
}

