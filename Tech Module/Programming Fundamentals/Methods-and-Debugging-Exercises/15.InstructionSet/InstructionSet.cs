namespace _15.InstructionSet
{
    using System;

    public class InstructionSet
    {
        static void Main()
        {
            string opCode = Console.ReadLine().ToUpper();

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                opCode = Console.ReadLine().ToUpper();

                long result = 0L;
                switch (codeArgs[0].ToUpper())
                {
                    case "INC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = operandOne;
                            result++;

                            break;
                        }
                    case "DEC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = operandOne;
                            result--;
                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = (long)operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = (long)operandOne * operandTwo;
                            break;
                        }
                }

                Console.WriteLine(result);
            }
        }
    }
}
