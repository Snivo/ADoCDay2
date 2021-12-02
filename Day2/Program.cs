namespace Day2;

public class Program
{
    struct Command
    {
        public string Cmd;
        public int Value;
    }

    public static void Main(string[] args)
    {
        SubPilotPt1 subPilot1 = new();
        SubPilotPt2 subPilot2 = new();
        StreamReader reader = new("input.txt");

        List<Command> commands = new();

        string? input = reader.ReadLine();

        while (input != null)
        {
            string[] split = input.Split(' ');

            commands.Add(new Command() { Cmd = split[0], Value = int.Parse(split[1]) });

            input = reader.ReadLine();
        }

        foreach(Command cmd in commands)
        {
            subPilot1.NextInstruction(cmd.Cmd, cmd.Value);
            subPilot2.NextInstruction(cmd.Cmd, cmd.Value);  
        }

        Console.WriteLine($"Pt1 result: ({subPilot1.Depth} * {subPilot1.Forward}): {subPilot1.Depth * subPilot1.Forward}");
        Console.WriteLine($"Pt2 result: ({subPilot2.Depth} * {subPilot2.Forward}): {subPilot2.Depth * subPilot2.Forward}");
    }
}