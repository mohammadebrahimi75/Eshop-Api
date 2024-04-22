namespace Common.Domain.Exceptions;

public class BaseDomainException : Exception
{
	public BaseDomainException()
	{

	}

	public BaseDomainException(string message) : base(message)//string message daryaft mikonad v midahad be base ke class exception hast ke exception baraie ma ba in payam sabt konad
	{

	}
}