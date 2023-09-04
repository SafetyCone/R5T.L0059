using System;

using R5T.T0132;


namespace R5T.L0059
{
    [FunctionalityMarker]
    public partial interface IFileSystemOperator : IFunctionalityMarker,
        L0057.IFileSystemOperator,
        L0060.IFileSystemOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public new L0054.IFileSystemOperator _Platform => L0054.FileSystemOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
