using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Instruction_Set
{
    class InstructionSet_fixed
    {
        static void Main(string[] args)
        {
            string opCode = string.Empty;

            while (opCode != "END")
            {
                opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
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
                            result = (long)operandOne + (long)operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = (long)operandOne * (long)operandTwo;
                            break;
                        }
                }

                if (!opCode.Equals("END"))
                    Console.WriteLine(result);

            }
        }
    }
}
