using System;


namespace R5T.Z0029
{
    public class Syntax : ISyntax
    {
        #region Infrastructure

        public static ISyntax Instance { get; } = new Syntax();


        private Syntax()
        {
        }

        #endregion
    }
}
