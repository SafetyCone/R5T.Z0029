using System;


namespace R5T.Z0029
{
    public class Keywords : IKeywords
    {
        #region Infrastructure

        public static IKeywords Instance { get; } = new Keywords();


        private Keywords()
        {
        }

        #endregion
    }
}
