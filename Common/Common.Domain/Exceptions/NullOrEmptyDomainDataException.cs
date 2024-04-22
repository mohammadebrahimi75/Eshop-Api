namespace Common.Domain.Exceptions;

public class NullOrEmptyDomainDataException : BaseDomainException
{
	public NullOrEmptyDomainDataException()
	{

	}

	public NullOrEmptyDomainDataException(string message) : base(message)
	{

	}

	public static void CheckString(string value, string nameOffield)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new NullOrEmptyDomainDataException($"{nameOffield} is null or empty");
		}
	}
}