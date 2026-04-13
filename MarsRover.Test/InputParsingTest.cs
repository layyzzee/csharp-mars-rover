using MarsRover.Terminal;
using NUnit.Framework;

namespace MarsRover.Tests;

public class InputParsingTest
{
    [Test]
    public void PlateauParser_ReturnNull_WithinputEmpty()
    {
        var result = InputParser.PlateauParser("");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_ReturnNull_WithinputBlankSpace()
    {
        var result = InputParser.PlateauParser(" ");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_ReturnNull_Withinput5()
    {
        var result = InputParser.PlateauParser("5");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_ReturnNull_WithinputNonDigit()
    {
        var result = InputParser.PlateauParser("!");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void PlateauParser_Return5x5_Withinputx5y5()
    {
        var result = InputParser.PlateauParser("5 5");
        var expected = new Plateau(5, 5);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void PlateauParser_Return9x9_Withinputx9y9()
    {
        var result = InputParser.PlateauParser("9 9");
        var expected = new Plateau(9, 9);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void PlateauParser_ReturnError_Withinputx15y5()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => 
        InputParser.PlateauParser("15 5"));
    }
    [Test]
    public void PlateauParser_ReturnError_Withinputx5y15()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        InputParser.PlateauParser("5 15"));
    }
    [Test]
    public void PlateauParser_ReturnNull_Withinputx15y15()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        InputParser.PlateauParser("15 15"));
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6N_WithinputX3Y6N()
    {
        var result = InputParser.StartingPointParser("3 6 N");
        var expected = new Position(3, 6, Compass.N);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6E_WithinputX3Y6E()
    {
        var result = InputParser.StartingPointParser("3 6 E");
        var expected = new Position(3, 6, Compass.E);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6S_WithinputX3Y6S()
    {
        var result = InputParser.StartingPointParser("3 6 S");
        var expected = new Position(3, 6, Compass.S);
        Assert.That(result == expected, Is.True);
    }
    [Test]
    public void StartingPointParser_ReturnX3Y6W_WithinputX3Y6W()
    {
        var result = InputParser.StartingPointParser("3 6 W");
        var expected = new Position(3, 6, Compass.W);
        Assert.That(result == expected, Is.True);
    }
    //[Test]        //Test Later
    //public void StartingPointParser_ReturnNull_WithinputOutsidePlateau()
    //{
    //    InputParsing.PlateauParser("10 10");
    //    Assert.Throws<ArgumentOutOfRangeException>(() => InputParsing.StartingPointParser("15 12 W"));
    //}
    [Test]
    public void StartingPointParser_ReturnNull_WithinputTooManyArgs()
    {
        InputParser.PlateauParser("10 10");
        var result = InputParser.StartingPointParser("15 12 W E");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void StartingPointParser_ReturnNull_WithinputLackingEnum()
    {
        InputParser.PlateauParser("10 10");
        var result = InputParser.StartingPointParser("8 3 e");
        Assert.That(result, Is.Null);
    }
    [Test]
    public void MoveRover_ReturnNull_WithinputEmpty()
    {
        var result = InputParser.RoverMovementParse("MR1ML");
        var expected = new List<Instruction>() { Instruction.M, Instruction.R, Instruction.M, Instruction.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void MoveRover_ReturnMRML_WithinputMRML()
    {
        var result = InputParser.RoverMovementParse("MRML");
        var expected = new List<Instruction>() { Instruction.M, Instruction.R, Instruction.M, Instruction.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void MoveRover_ReturnMRML_WithinputMRIML()
    {
        var result = InputParser.RoverMovementParse("MRIML");
        var expected = new List<Instruction>() { Instruction.M, Instruction.R, Instruction.M, Instruction.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void MoveRover_ReturnMRML_WithinputMR1ML()
    {
        var result = InputParser.RoverMovementParse("MR1ML");
        var expected = new List<Instruction>() { Instruction.M, Instruction.R, Instruction.M, Instruction.L };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void InstructionParser_ReturnsL_WhenInputL()
    {
        var input = "L";
        var result = InputParser.InstructionParser(input);
        var expected = new List<Instruction> { Instruction.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void InstructionParser_ReturnsR_WhenInputR()
    {
        var input = "L";
        var result = InputParser.InstructionParser(input);
        var expected = new List<Instruction> { Instruction.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void InstructionParser_ReturnsNull_WhenInputInvalid()
    {
        var input = "X";
        Assert.Throws<ArgumentException>(() => InputParser.InstructionParser(input));
    }
    [Test]
    public void InstructionParser_ReturnsList_WhenInputMixed()
    {
        var input = "LX";
        var result = InputParser.InstructionParser(input);
        var expected = new List<Instruction> { Instruction.L };
        Assert.That(result, Is.EqualTo(expected));
    }
    public void InstructionParser_ReturnsList_WhenMultipleInputValid()
    {
        var input = "LRRMLLM";
        var result = InputParser.InstructionParser(input);
        var expected = new List<Instruction> { Instruction.L, Instruction.R, Instruction.R, Instruction.M, Instruction.L, Instruction.L, Instruction.M };
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void InstructionParser_ReturnsList_WhenMultipleInputValidAndInvalid()
    {
        var input = "LRXRMILCATLM";
        var result = InputParser.InstructionParser(input);
        var expected = new List<Instruction> { Instruction.L, Instruction.R, Instruction.R, Instruction.M, Instruction.L, Instruction.L, Instruction.M };
        Assert.That(result, Is.EqualTo(expected));
    }
}