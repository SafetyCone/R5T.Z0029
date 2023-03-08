using System;

using R5T.T0131;


namespace R5T.Z0029
{
    [ValuesMarker]
    public partial interface ISyntax : IValuesMarker
    {
        /// <inheritdoc cref="Z0000.IStrings.Comma"/>
        public string ArgumentsListTokenSeparator => Instances.Strings.Comma;

        /// <inheritdoc cref="Z0000.ICharacters.Comma"/>
        public char ArgumentsListTokenSeparator_Character => Instances.Characters.Comma;

        /// <inheritdoc cref="Z0000.IStrings.CloseParenthesis"/>
        public string ArgumentsListParenthesis_Close => Instances.Strings.CloseParenthesis;

        /// <inheritdoc cref="Z0000.ICharacters.CloseParenthesis"/>
        public char ArgumentsListParenthesis_Close_Character => Instances.Characters.CloseParenthesis;

        /// <inheritdoc cref="Z0000.IStrings.OpenParenthesis"/>
        public string ArgumentsListParenthesis_Open => Instances.Strings.OpenParenthesis;

        /// <inheritdoc cref="Z0000.ICharacters.OpenParenthesis"/>
        public char ArgumentsListParenthesis_Open_Character => Instances.Characters.OpenParenthesis;

        /// <inheritdoc cref="Z0000.IStrings.OpenAngleBracket"/>
        public string GenericTypeArgumentListBracket_Close => Instances.Strings.CloseAngleBracket;

        /// <inheritdoc cref="Z0000.ICharacters.OpenAngleBracket"/>
        public char GenericTypeArgumentListBracket_Close_Character => Instances.Characters.CloseAngleBracket;

        /// <inheritdoc cref="Z0000.IStrings.OpenAngleBracket"/>
        public string GenericTypeArgumentListBracket_Open => Instances.Strings.OpenAngleBracket;

        /// <inheritdoc cref="Z0000.ICharacters.OpenAngleBracket"/>
        public char GenericTypeArgumentListBracket_Open_Character => Instances.Characters.OpenAngleBracket;

        /// <inheritdoc cref="Z0000.IStrings.Period"/>
        public string NamespaceTokenSeparator => Instances.Strings.Period;

        /// <inheritdoc cref="Z0000.ICharacters.Period"/>
        public char NamespaceTokenSeparator_Character => Instances.Characters.Period;

        /// <inheritdoc cref="Z0000.IStrings.Space"/>
        public string Space => Instances.Strings.Space;

        /// <inheritdoc cref="Z0000.ICharacters.Space"/>
        public char Space_Character => Instances.Characters.Space;
    }
}
