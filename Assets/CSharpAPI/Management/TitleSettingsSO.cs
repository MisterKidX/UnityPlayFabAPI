using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayFabAPI.Management
{
    [CreateAssetMenu(menuName = "PlayFab/Title Settings SO", fileName = "PlayFab Title Settings")]
    public class TitleSettingsSO : ScriptableObject
    {
        [SerializeField]
        string _titleID;
        public string TitleID => _titleID;
    }
}