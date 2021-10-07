using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace PlayFabAPI.Login
{
    public abstract class BaseLoginProcedure : ILogin
    {
        public abstract Task Login();
    }
}