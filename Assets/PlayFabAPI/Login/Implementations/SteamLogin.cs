using System.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

// TO ADD:
// https://docs.microsoft.com/en-us/gaming/playfab/features/authentication/platform-specific-authentication/steam-unity
// https://docs.microsoft.com/en-us/rest/api/playfab/client/authentication/login-with-steam?view=playfab-rest
// Make sure developer knows to use the steam addon on playfab

namespace PlayFabAPI.Login
{

#if !DISABLESTEAMWORKS

    /// <summary>
    /// TBD
    /// </summary>
    public class SteamLogin : BaseLoginProcedure
    {
        private string _titleID = null;

        public SteamLogin(string titleID)
        {
            _titleID = titleID;
        }

        public async override Task Login()
        {
            LoginWithSteamRequest request = new LoginWithSteamRequest { TitleId = _titleID };
            var result = await PlayFabClientAPI.LoginWithSteamAsync(request);
            PlayFabUtilities.LogError(result.Error);
            return;
        }
    }
#endif

}