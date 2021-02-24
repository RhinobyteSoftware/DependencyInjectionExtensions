﻿using System.Reflection.Emit;

namespace Rhinobyte.ReflectionHelpers.Instructions
{
	/// <summary>
	/// Instruction class with an associated signature blob <see cref="byte"/>[].
	/// </summary>
	public sealed class SignatureInstruction : InstructionBase
	{
		private readonly byte[] _signatureBlob;

		internal SignatureInstruction(int offset, OpCode opcode, byte[] signatureBlob)
			: base(offset, opcode, opcode.Size + OpCodeHelper.GetOperandSize(opcode.OperandType))
		{
			_signatureBlob = signatureBlob;
		}

		/// <summary>
		/// Returns a copy of the instruction's singature blob <see cref="byte"/>[].
		/// </summary>
		public byte[] GetSignatureBlob()
		{
			// Need to return a clone of the array so that consumers of this library cannot change its contents
			return (byte[])_signatureBlob.Clone();
		}

		public override string ToString()
		{
			if (_signatureBlob == null)
			{
				return $"{base.ToString()}  [SignatureBlob: null]";
			}

			return $"{base.ToString()}  [SignatureBlob: {_signatureBlob.Length} bytes]";
		}
	}
}
