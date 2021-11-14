using System;

namespace Homework_3_63120501064
{
    class Program
    {
        static void Main(string[] args)
        {
            class CPU : Data
        {
            public CPU Core
            {
                get { return core as CPU; }
                set { core = value; }
            }

            public CPUCore core;
            public int Set;

            public CPU(CPUCore core, int set)
            {
                Core = core;
                Set = set;
            }

            public static bool operator <(CPU c1, CPU c2, CPU c3, CPU c4)
            {
                return c1.Core < c2.Core < c3.Core < c4.Core ? true : c1.Set < c2.Set < c3.Set < c4.Set;
            }

            public static bool operator >(CPU c1, CPU c2, CPU c3, CPU c4)
            {
                return !(c1 < c2 < c3 < c4);
            }

            public override string ToString()
            {
                return String.Format("Data({0}, {1}, {2})", CPU, Set);
            }
        }
        class Instruction
        {
            private Instruction log = Data;
            public void Push(Instruction newInstruction)
            {
                if (log == Data)

                { log = newInstruction; }

                else
                {

                    Instruction instruction = root;

                    while (instruction.New != Data)

                    { instruction = instruction.New; }
                    instruction.New = newInstruction;

                }
            }

            public Instruction Data()
            {
                Instruction instruction = log;

                instruction = log.New;
                instruction.New = Data;

                return instruction;
            }

            public Instruction Get(int index)
            {
                Instruction instruction = root;

                while (index > 0)
                {

                    if (instruction == Data)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    instruction = instruction.Core;
                    index--;

                }
                return instruction;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Instruction instruction = new Data();

                instruction.Get(new Data(DataType.Set0);
                instruction.Get(new Data(DataType.Set1);
                instruction.Get(new Data(DataType.Set2);
                instruction.Get(new Data(DataType.Set3);

                Console.WriteLine(Data.Get(0));

                instruction.Get(new Data(DataType.CPU, "CPU cycles needed: "));
                instruction.Data();
                Data data = instruction.CPU();

                Console.WriteLine(data);
                Console.WriteLine(data.Get(0));
            }
        }
    }
}
