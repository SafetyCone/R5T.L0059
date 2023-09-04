using System;

using R5T.T0132;


namespace R5T.L0059
{
    [FunctionalityMarker]
    public partial interface IPortableExecutableOperator : IFunctionalityMarker,
        L0060.IPortableExecutableOperator
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0054.IPortableExecutableOperator _Platform => L0054.PortableExecutableOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
