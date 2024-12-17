namespace maingame.tests;

using GdUnit4;
using static GdUnit4.Assertions;

[TestSuite]
public class UnitTestExample
{
	
	[TestCase]
	public void VerifyLengthContent()
	{
		// Verify the given string by using `AssertString`
		AssertString("This is a example message")
			// We expect a lenght equal 25 characters
			.HasLength(25)
			// The message must start wiht `This is a ex`
			.StartsWith("This is a ex");
	}
	
	[TestCase]
	public void StringToLower()
	{
		AssertString("AbcD".ToLower()).IsEqual("abcd");
	}

	
}
