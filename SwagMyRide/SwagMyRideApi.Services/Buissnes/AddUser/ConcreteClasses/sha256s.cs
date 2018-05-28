using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using SwagMyRideApi.Services.Buissnes.AddUser.Abstract;

namespace SwagMyRideApi.Services.Buissnes.AddUser.ConcreteClasses
{
    public class Sha256S : SecurityAlgorithm
    {
        private new string Pass;

        public Sha256S(string pass) : base("pass")
        {
            Pass = pass;
        }


        public override string Generated()
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 sha256 = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] resultbBytes = sha256.ComputeHash(enc.GetBytes(Pass));

                foreach (var b in resultbBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                Pass = sb.ToString();
                return Pass;
            }
        }


    }
}
