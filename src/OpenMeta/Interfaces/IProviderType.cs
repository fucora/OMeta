using System;
using System.Runtime.InteropServices;

namespace MyMeta
{
    [Guid("C7B1A534-B355-4A06-AD0F-FFF4DBF5B374"),InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IProviderType 
	{
		string Type { get; }
		System.Int32 DataType { get; }
		System.Int32 ColumnSize { get; }
		string LiteralPrefix { get; }
		string LiteralSuffix { get; }
		string CreateParams { get; }
		System.Boolean IsNullable { get; }
		System.Boolean IsCaseSensitive { get; }
		string Searchable { get; } // convert
		System.Boolean IsUnsigned { get; }
		System.Boolean HasFixedPrecScale { get; }
		System.Boolean CanBeAutoIncrement { get; }
		string LocalType { get; }
		System.Int32 MinimumScale { get; }
		System.Int32 MaximumScale { get; }
		Guid TypeGuid { get; }
		string TypeLib { get; }
		string Version { get; }
		System.Boolean IsLong { get; }
		System.Boolean BestMatch { get; }
		System.Boolean IsFixedLength { get; }
	}
}

