using System;

using R5T.T0132;


namespace R5T.L0059
{
    [FunctionalityMarker]
    public partial interface IAssemblyNameOperator : IFunctionalityMarker,
        L0060.IAssemblyNameOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0054.IAssemblyNameOperator _Platform => L0054.AssemblyNameOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
