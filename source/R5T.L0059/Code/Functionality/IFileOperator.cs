using System;

using R5T.T0132;


namespace R5T.L0059
{
    [FunctionalityMarker]
    public partial interface IFileOperator : IFunctionalityMarker,
        L0057.IFileOperator,
        L0060.IFileOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public new L0054.IFileOperator _Platform => L0054.FileOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
