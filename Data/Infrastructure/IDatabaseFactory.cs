using System;

namespace Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        MyFinanceContext DataContext { get; }
    }

}