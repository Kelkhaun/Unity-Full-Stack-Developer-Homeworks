using NUnit.Framework;

public class ConverterTests
{
  [Test]
  public void InstantiateConverter()
  {
      Converter converter = new();

      Assert.IsNotNull(converter);

  }
}