using System;

using R5T.T0132;


namespace R5T.L0059
{
    [FunctionalityMarker]
    public partial interface IExecutablePathOperator : IFunctionalityMarker,
        L0060.IExecutablePathOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public new L0054.IExecutablePathOperator _Platform => L0054.ExecutablePathOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
