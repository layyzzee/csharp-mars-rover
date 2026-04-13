using MarsRover.Terminal;
using NUnit.Framework;

namespace MarsRover.Tests;

public class InputParsingTest
{
    [Test]
    public void PlateauParser_ReturnNull_WithinputEmpty()
    {
        var result = InputParsing.PlateauParser("");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_ReturnNull_WithinputBlankSpace()
    {
        var result = InputParsing.PlateauParser(" ");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_ReturnNull_Withinput5()
    {
        var result = InputParsing.PlateauParser("5");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_ReturnNull_WithinputNonDigit()
    {
        var result = InputParsing.PlateauParser("!");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_Return5x5_Withinputx5y5()
    {
        var result = InputParsing.PlateauParser("5 5");
        var expected = new Plateau(5, 5);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void PlateauParser_Return9x9_Withinputx9y9()
    {
        var result = InputParsing.PlateauParser("9 9");
        var expected = new Plateau(9, 9);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void PlateauParser_ReturnError_Withinputx15y5()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => 
        InputParsing.PlateauParser("15 5"));
    }
    [Test]
    public void PlateauParser_ReturnError_Withinputx5y15()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        InputParsing.PlateauParser("5 15"));
    }
    [Test]
    public void PlateauParser_ReturnNull_Withinputx15y15()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        InputParsing.PlateauParser("15 15"));
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6N_WithinputX3Y6N()
    {
        var result = InputParsing.StartingPointParser("3 6 N");
        var expected = new Position(3, 6, Compass.N);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6E_WithinputX3Y6E()
    {
        var result = InputParsing.StartingPointParser("3 6 E");
        var expected = new Position(3, 6, Compass.E);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6S_WithinputX3Y6S()
    {
        var result = InputParsing.StartingPointParser("3 6 S");
        var expected = new Position(3, 6, Compass.S);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6W_WithinputX3Y6W()
    {
        var result = InputParsing.StartingPointParser("3 6 W");
        var expected = new Position(3, 6, Compass.W);
        Assert.That(result == expected, Is.True);
    }
    //[Test]        //Test Later
    //public void StartingPointParser_ReturnNull_WithinputOutsidePlateau()
    //{
    //    InputParsing.PlateauParser("10 10");
    //    var result = InputParsing.StartingPointParser("15 12 W");
    //    Assert.That(result, Is.Null);
    //}
    [Test]
    public void StartingPointParser_ReturnNull_WithinputTooManyArgs()
    {
        InputParsing.PlateauParser("10 10");
        var result = InputParsing.StartingPointParser("15 12 W E");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void StartingPointParser_ReturnNull_WithinputLackingEnum()
    {
        InputParsing.PlateauParser("10 10");
        var result = InputParsing.StartingPointParser("8 3 e");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void MoveRover_ReturnNull_WithinputEmpty()
    {
        var result = InputParsing.RoverMovementParse("MR1ML");
        var expected = new List<Movement>() { Movement.M, Movement.R, Movement.M, Movement.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void MoveRover_ReturnMRML_WithinputMRML()
    {
        var result = InputParsing.RoverMovementParse("MRML");
        var expected = new List<Movement>() { Movement.M, Movement.R, Movement.M, Movement.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void MoveRover_ReturnMRML_WithinputMRIML()
    {
        var result = InputParsing.RoverMovementParse("MRIML");
        var expected = new List<Movement>() { Movement.M, Movement.R, Movement.M, Movement.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void MoveRover_ReturnMRML_WithinputMR1ML()
    {
        var result = InputParsing.RoverMovementParse("MR1ML");
        var expected = new List<Movement>() { Movement.M, Movement.R, Movement.M, Movement.L };
        Assert.That(result, Is.EqualTo(expected));
    }
}