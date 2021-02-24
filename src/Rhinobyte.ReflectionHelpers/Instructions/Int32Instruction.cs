﻿using System.Reflection.Emit;

namespace Rhinobyte.ReflectionHelpers.Instructions
{
	/// <summary>
	/// Instruction class with an associated <see cref="int"/> value operand.
	/// </summary>
	public sealed class Int32Instruction : InstructionBase
	{
		internal Int32Instruction(int offset, OpCode opcode, int value)
			: base(offset, opcode, opcode.Size + OpCodeHelper.GetOperandSize(opcode.OperandType))
		{
			Value = value;
		}

		/// <summary>
		/// The <see cref="int"/> value of the instruction.
		/// </summary>
		public int Value { get; }

		public override string ToString()
			=> $"{base.ToString()}  [Int32 Value: {Value}]";
	}
}
