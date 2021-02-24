﻿using System.Reflection.Emit;

namespace Rhinobyte.ReflectionHelpers.Instructions
{
	/// <summary>
	/// Instruction class with an associated <see cref="byte"/> value operand.
	/// </summary>
	public sealed class ByteInstruction : InstructionBase
	{
		internal ByteInstruction(int offset, OpCode opcode, byte value)
			: base(offset, opcode, opcode.Size + OpCodeHelper.GetOperandSize(opcode.OperandType))
		{
			Value = value;
		}

		/// <summary>
		/// The <see cref="byte"/> value of the instruction.
		/// </summary>
		public byte Value { get; }

		public override string ToString()
			=> $"{base.ToString()}  [Byte Value: {Value}]";
	}
}
