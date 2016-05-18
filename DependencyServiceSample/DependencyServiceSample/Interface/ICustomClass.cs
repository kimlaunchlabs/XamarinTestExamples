using System;

namespace DependencyServiceSample
{
	// Creating Interface ICustomClass with a GoNative method
	// Interfaces help to create a consistent architecture for specifying cross-platform feature sets with platform-specific implementations.
	public interface ICustomClass
	{
		string GoNative (string param);
	}
}

