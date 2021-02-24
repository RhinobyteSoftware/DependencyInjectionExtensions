﻿using System.Reflection.Emit;

namespace Rhinobyte.ReflectionHelpers.Instructions
{
	public sealed class FloatInstruction : InstructionBase
	{
		public FloatInstruction(int offset, OpCode opcode, float value)
			: base(offset, opcode, opcode.Size + OpCodeHelper.GetOperandSize(opcode.OperandType))
		{
			Value = value;
		}

		/// <summary>
		/// The <see cref="float"/> value of the instruction.
		/// </summary>
		public float Value { get; }

		public override string ToString()
			=> $"{base.ToString()}  [Float Value: {Value}]";
	}
}
