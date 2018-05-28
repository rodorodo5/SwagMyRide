using Microsoft.CodeAnalysis.Diagnostics;

namespace SwagMyRideApi.Services.Buissnes.AddUser.Abstract
{
    public abstract class SecurityAlgorithm
    {
        private string Pass;

        protected SecurityAlgorithm(string pass)
        {
            Pass = pass;
        }

        public abstract string Generated();
       
    }
}
