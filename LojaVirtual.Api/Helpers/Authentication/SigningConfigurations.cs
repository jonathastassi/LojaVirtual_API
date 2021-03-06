﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LojaVirtual.Api.Helpers.Authentication
{
    public class SigningConfigurations
    {
        private const string SECRET_KEY = "dwefwefq0312hf0233v4t3v4b54t45t43btv53v439023f";

        public SigningCredentials SigningCredentials { get; }
        private readonly SymmetricSecurityKey _signingkey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECRET_KEY));

        public SigningConfigurations()
        {
            SigningCredentials = new SigningCredentials(_signingkey, SecurityAlgorithms.HmacSha256);
        }
    }
}
