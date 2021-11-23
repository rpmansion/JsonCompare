namespace JsonCompare.Formatters
{
	public interface IFormatContext<out TResult>
	{
		TResult Result();
	}
}
